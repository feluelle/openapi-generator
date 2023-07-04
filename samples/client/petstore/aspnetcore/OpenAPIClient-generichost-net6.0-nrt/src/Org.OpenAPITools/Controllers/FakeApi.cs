/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using Org.OpenAPITools.Attributes;
using Org.OpenAPITools.Models;

namespace Org.OpenAPITools.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class FakeApiController : ControllerBase
    { 
        /// <summary>
        /// Health check endpoint
        /// </summary>
        /// <response code="200">The instance started successfully</response>
        [HttpGet]
        [Route("/v2/fake/health")]
        [ValidateModelState]
        [SwaggerOperation("FakeHealthGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(HealthCheckResult), description: "The instance started successfully")]
        public virtual IActionResult FakeHealthGet()
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(HealthCheckResult));
            string exampleJson = null;
            exampleJson = "{\n  \"NullableMessage\" : \"NullableMessage\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<HealthCheckResult>(exampleJson)
            : default(HealthCheckResult);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Test serialization of outer boolean types</remarks>
        /// <param name="body">Input boolean as post body</param>
        /// <response code="200">Output boolean</response>
        [HttpPost]
        [Route("/v2/fake/outer/boolean")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("FakeOuterBooleanSerialize")]
        [SwaggerResponse(statusCode: 200, type: typeof(bool), description: "Output boolean")]
        public virtual IActionResult FakeOuterBooleanSerialize([FromBody]bool? body)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(bool));
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<bool>(exampleJson)
            : default(bool);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Test serialization of object with outer number type</remarks>
        /// <param name="outerComposite">Input composite as post body</param>
        /// <response code="200">Output composite</response>
        [HttpPost]
        [Route("/v2/fake/outer/composite")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("FakeOuterCompositeSerialize")]
        [SwaggerResponse(statusCode: 200, type: typeof(OuterComposite), description: "Output composite")]
        public virtual IActionResult FakeOuterCompositeSerialize([FromBody]OuterComposite? outerComposite)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(OuterComposite));
            string exampleJson = null;
            exampleJson = "{\n  \"my_string\" : \"my_string\",\n  \"my_number\" : 0.8008281904610115,\n  \"my_boolean\" : true\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<OuterComposite>(exampleJson)
            : default(OuterComposite);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Test serialization of outer number types</remarks>
        /// <param name="body">Input number as post body</param>
        /// <response code="200">Output number</response>
        [HttpPost]
        [Route("/v2/fake/outer/number")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("FakeOuterNumberSerialize")]
        [SwaggerResponse(statusCode: 200, type: typeof(decimal), description: "Output number")]
        public virtual IActionResult FakeOuterNumberSerialize([FromBody]decimal? body)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(decimal));
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<decimal>(exampleJson)
            : default(decimal);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Test serialization of outer string types</remarks>
        /// <param name="requiredStringUuid">Required UUID String</param>
        /// <param name="body">Input string as post body</param>
        /// <response code="200">Output string</response>
        [HttpPost]
        [Route("/v2/fake/outer/string")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("FakeOuterStringSerialize")]
        [SwaggerResponse(statusCode: 200, type: typeof(string), description: "Output string")]
        public virtual IActionResult FakeOuterStringSerialize([FromQuery (Name = "required_string_uuid")][Required()]Guid requiredStringUuid, [FromBody]string? body)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(string));
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<string>(exampleJson)
            : default(string);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Array of Enums
        /// </summary>
        /// <response code="200">Got named array of enums</response>
        [HttpGet]
        [Route("/v2/fake/array-of-enums")]
        [ValidateModelState]
        [SwaggerOperation("GetArrayOfEnums")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<OuterEnum>), description: "Got named array of enums")]
        public virtual IActionResult GetArrayOfEnums()
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<OuterEnum>));
            string exampleJson = null;
            exampleJson = "[ null, null ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<OuterEnum>>(exampleJson)
            : default(List<OuterEnum>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>For this test, the body for this request much reference a schema named &#x60;File&#x60;.</remarks>
        /// <param name="fileSchemaTestClass"></param>
        /// <response code="200">Success</response>
        [HttpPut]
        [Route("/v2/fake/body-with-file-schema")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("TestBodyWithFileSchema")]
        public virtual IActionResult TestBodyWithFileSchema([FromBody]FileSchemaTestClass fileSchemaTestClass)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="user"></param>
        /// <response code="200">Success</response>
        [HttpPut]
        [Route("/v2/fake/body-with-query-params")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("TestBodyWithQueryParams")]
        public virtual IActionResult TestBodyWithQueryParams([FromQuery (Name = "query")][Required()]string query, [FromBody]User user)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// To test \&quot;client\&quot; model
        /// </summary>
        /// <remarks>To test \&quot;client\&quot; model</remarks>
        /// <param name="modelClient">client model</param>
        /// <response code="200">successful operation</response>
        [HttpPatch]
        [Route("/v2/fake")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("TestClientModel")]
        [SwaggerResponse(statusCode: 200, type: typeof(ModelClient), description: "successful operation")]
        public virtual IActionResult TestClientModel([FromBody]ModelClient modelClient)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ModelClient));
            string exampleJson = null;
            exampleJson = "{\n  \"client\" : \"client\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ModelClient>(exampleJson)
            : default(ModelClient);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Fake endpoint for testing various parameters 假端點 偽のエンドポイント 가짜 엔드 포인트 
        /// </summary>
        /// <remarks>Fake endpoint for testing various parameters 假端點 偽のエンドポイント 가짜 엔드 포인트 </remarks>
        /// <param name="number">None</param>
        /// <param name="varDouble">None</param>
        /// <param name="patternWithoutDelimiter">None</param>
        /// <param name="varByte">None</param>
        /// <param name="integer">None</param>
        /// <param name="int32">None</param>
        /// <param name="int64">None</param>
        /// <param name="varFloat">None</param>
        /// <param name="varString">None</param>
        /// <param name="binary">None</param>
        /// <param name="date">None</param>
        /// <param name="dateTime">None</param>
        /// <param name="password">None</param>
        /// <param name="callback">None</param>
        /// <response code="400">Invalid username supplied</response>
        /// <response code="404">User not found</response>
        [HttpPost]
        [Route("/v2/fake")]
        [Consumes("application/x-www-form-urlencoded")]
        [ValidateModelState]
        [SwaggerOperation("TestEndpointParameters")]
        public virtual IActionResult TestEndpointParameters([FromForm (Name = "number")][Required()][Range(32.1, 543.2)]decimal number, [FromForm (Name = "double")][Required()][Range(67.8, 123.4)]double varDouble, [FromForm (Name = "pattern_without_delimiter")][Required()][RegularExpression("^[A-Z].*")]string patternWithoutDelimiter, [FromForm (Name = "byte")][Required()]byte[] varByte, [FromForm (Name = "integer")][Range(10, 100)]int? integer, [FromForm (Name = "int32")][Range(20, 200)]int? int32, [FromForm (Name = "int64")]long? int64, [FromForm (Name = "float")]float? varFloat, [FromForm (Name = "string")][RegularExpression("/[a-z]/i")]string? varString, System.IO.Stream? binary, [FromForm (Name = "date")]DateTime? date, [FromForm (Name = "dateTime")]DateTime? dateTime, [FromForm (Name = "password")][StringLength(64, MinimumLength=10)]string? password, [FromForm (Name = "callback")]string? callback)
        {

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            throw new NotImplementedException();
        }

        /// <summary>
        /// To test enum parameters
        /// </summary>
        /// <remarks>To test enum parameters</remarks>
        /// <param name="enumHeaderStringArray">Header parameter enum test (string array)</param>
        /// <param name="enumHeaderString">Header parameter enum test (string)</param>
        /// <param name="enumQueryStringArray">Query parameter enum test (string array)</param>
        /// <param name="enumQueryString">Query parameter enum test (string)</param>
        /// <param name="enumQueryInteger">Query parameter enum test (double)</param>
        /// <param name="enumQueryDouble">Query parameter enum test (double)</param>
        /// <param name="enumFormStringArray">Form parameter enum test (string array)</param>
        /// <param name="enumFormString">Form parameter enum test (string)</param>
        /// <response code="400">Invalid request</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/v2/fake")]
        [Consumes("application/x-www-form-urlencoded")]
        [ValidateModelState]
        [SwaggerOperation("TestEnumParameters")]
        public virtual IActionResult TestEnumParameters([FromHeader]List<string>? enumHeaderStringArray, [FromHeader]string? enumHeaderString, [FromQuery (Name = "enum_query_string_array")]List<string>? enumQueryStringArray, [FromQuery (Name = "enum_query_string")]string? enumQueryString, [FromQuery (Name = "enum_query_integer")]int? enumQueryInteger, [FromQuery (Name = "enum_query_double")]double? enumQueryDouble, [FromForm (Name = "enum_form_string_array")]List<string>? enumFormStringArray, [FromForm (Name = "enum_form_string")]string? enumFormString)
        {

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Fake endpoint to test group parameters (optional)
        /// </summary>
        /// <remarks>Fake endpoint to test group parameters (optional)</remarks>
        /// <param name="requiredStringGroup">Required String in group parameters</param>
        /// <param name="requiredBooleanGroup">Required Boolean in group parameters</param>
        /// <param name="requiredInt64Group">Required Integer in group parameters</param>
        /// <param name="stringGroup">String in group parameters</param>
        /// <param name="booleanGroup">Boolean in group parameters</param>
        /// <param name="int64Group">Integer in group parameters</param>
        /// <response code="400">Something wrong</response>
        [HttpDelete]
        [Route("/v2/fake")]
        [Authorize]
        [ValidateModelState]
        [SwaggerOperation("TestGroupParameters")]
        public virtual IActionResult TestGroupParameters([FromQuery (Name = "required_string_group")][Required()]int requiredStringGroup, [FromHeader][Required()]bool requiredBooleanGroup, [FromQuery (Name = "required_int64_group")][Required()]long requiredInt64Group, [FromQuery (Name = "string_group")]int? stringGroup, [FromHeader]bool? booleanGroup, [FromQuery (Name = "int64_group")]long? int64Group)
        {

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            throw new NotImplementedException();
        }

        /// <summary>
        /// test inline additionalProperties
        /// </summary>
        /// <param name="requestBody">request body</param>
        /// <response code="200">successful operation</response>
        [HttpPost]
        [Route("/v2/fake/inline-additionalProperties")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("TestInlineAdditionalProperties")]
        public virtual IActionResult TestInlineAdditionalProperties([FromBody]Dictionary<string, string> requestBody)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// test json serialization of form data
        /// </summary>
        /// <param name="param">field1</param>
        /// <param name="param2">field2</param>
        /// <response code="200">successful operation</response>
        [HttpGet]
        [Route("/v2/fake/jsonFormData")]
        [Consumes("application/x-www-form-urlencoded")]
        [ValidateModelState]
        [SwaggerOperation("TestJsonFormData")]
        public virtual IActionResult TestJsonFormData([FromForm (Name = "param")][Required()]string param, [FromForm (Name = "param2")][Required()]string param2)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>To test the collection format in query parameters</remarks>
        /// <param name="pipe"></param>
        /// <param name="ioutil"></param>
        /// <param name="http"></param>
        /// <param name="url"></param>
        /// <param name="context"></param>
        /// <param name="requiredNotNullable"></param>
        /// <param name="requiredNullable"></param>
        /// <param name="notRequiredNotNullable"></param>
        /// <param name="notRequiredNullable"></param>
        /// <response code="200">Success</response>
        [HttpPut]
        [Route("/v2/fake/test-query-parameters")]
        [ValidateModelState]
        [SwaggerOperation("TestQueryParameterCollectionFormat")]
        public virtual IActionResult TestQueryParameterCollectionFormat([FromQuery (Name = "pipe")][Required()]List<string> pipe, [FromQuery (Name = "ioutil")][Required()]List<string> ioutil, [FromQuery (Name = "http")][Required()]List<string> http, [FromQuery (Name = "url")][Required()]List<string> url, [FromQuery (Name = "context")][Required()]List<string> context, [FromQuery (Name = "requiredNotNullable")][Required()]string requiredNotNullable, [FromQuery (Name = "requiredNullable")][Required()]string? requiredNullable, [FromQuery (Name = "notRequiredNotNullable")]string? notRequiredNotNullable, [FromQuery (Name = "notRequiredNullable")]string? notRequiredNullable)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }
    }
}
