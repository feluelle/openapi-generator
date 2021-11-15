import Foundation
import Combine

// MARK: - Open API Scheme

public enum SecurityScheme {
    case bearer
    // Other schemes not supported yet https://swagger.io/docs/specification/authentication/
}

// MARK: - Authenticator

public protocol Authenticator {
    func authenticate(request: URLRequest, securitySchemes: [SecurityScheme]) -> AnyPublisher<URLRequest, Error>
    func refresh() -> AnyPublisher<Void, Error>
}

/// Authenticator which does not authenticate requests and does not refresh it
open class EmptyAuthenticator: Authenticator {
    public func authenticate(request: URLRequest, securitySchemes: [SecurityScheme]) -> AnyPublisher<URLRequest, Error> {
        Just(request)
            .setFailureType(to: Error.self)
            .eraseToAnyPublisher()
    }

    public func refresh() -> AnyPublisher<Void, Error> {
        Just(())
            .setFailureType(to: Error.self)
            .eraseToAnyPublisher()
    }

    public init() {
    }
}

// MARK: - Transport

public protocol Transport {
    var baseURL: URL { get }
    func send(request: URLRequest, securitySchemes: [SecurityScheme]) -> AnyPublisher<TransportResponse, TransportError>
}

public struct TransportResponse {
    public let data: Data
    public let statusCode: Int
}

public struct TransportError: Error {
    public let data: Data
    public let statusCode: Int
    public let nestedError: Error?
}

public extension TransportError {
    // Impossible to add authentication headers to request
    static let incorrectAuthenticationCode = 601
    // Error while refreshing authentication
    static let failedAuthenticationRefreshCode = 602
    // There is no HTTP URL response
    static let noResponseCode = 603
}

public protocol URLSessionTransportDelegate: AnyObject {
    func willStart(request: URLRequest)
    func didFinish(request: URLRequest, response: HTTPURLResponse?)
}

open class URLSessionTransport: Transport {
    private var cancellable = Set<AnyCancellable>()
    let session: URLSession
    let authenticator: Authenticator
    // Amount of time application will refresh authentication and try performing network call again
    let authenticationRetryLimit = 1
    public let baseURL: URL
    public weak var delegate: URLSessionTransportDelegate?

    public init(baseURL: URL, session: URLSession = .shared, authenticator: Authenticator = EmptyAuthenticator()) {
        self.baseURL = baseURL
        self.session = session
        self.authenticator = authenticator
    }

    open func send(request: URLRequest, securitySchemes: [SecurityScheme]) -> AnyPublisher<TransportResponse, TransportError> {
        send(request: request, securitySchemes: securitySchemes, triesLeft: authenticationRetryLimit)
    }

    func send(request: URLRequest, securitySchemes: [SecurityScheme], triesLeft: Int) -> AnyPublisher<TransportResponse, TransportError> {
        authenticator
            // Add authentication headers if needed before request
            .authenticate(request: request, securitySchemes: securitySchemes)
            .mapError {
                TransportError(data: Data(), statusCode: TransportError.incorrectAuthenticationCode, nestedError: $0)
            }
            .flatMap { request -> AnyPublisher<TransportResponse, TransportError> in
                self.delegate?.willStart(request: request)
                // Perform network call
                return URLSession.shared.dataTaskPublisher(for: request)
                    .mapError { TransportError(data: Data(), statusCode: $0.code.rawValue, nestedError: nil) }
                    .flatMap { output -> AnyPublisher<TransportResponse, TransportError> in
                        let response = output.response as? HTTPURLResponse
                        self.delegate?.didFinish(request: request, response: response)
                        switch response?.statusCode {
                        case .some(200):
                            let transportResponse = TransportResponse(data: output.data, statusCode: 200)
                            return Result.success(transportResponse).publisher.eraseToAnyPublisher()
                        case .some(401) where triesLeft > 0:
                            // Refresh authentication if possible
                            return self.authenticator
                                .refresh()
                                .mapError {
                                    TransportError(data: Data(), statusCode: TransportError.failedAuthenticationRefreshCode, nestedError: $0)
                                }
                                .flatMap {
                                    // Try performing network call again
                                    self.send(request: request, securitySchemes: securitySchemes, triesLeft: triesLeft - 1)
                                }
                                .eraseToAnyPublisher()
                        case let .some(status):
                            let error = TransportError(data: output.data, statusCode: status, nestedError: nil)
                            return Fail(error: error).eraseToAnyPublisher()
                        default:
                            let error = TransportError(data: output.data, statusCode: TransportError.noResponseCode, nestedError: nil)
                            return Fail(error: error).eraseToAnyPublisher()
                        }
                    }
                    .eraseToAnyPublisher()
            }
            .eraseToAnyPublisher()
    }
}
