package org.openapitools.client.infrastructure

import com.squareup.moshi.Moshi
import com.squareup.moshi.kotlin.reflect.KotlinJsonAdapterFactory
import java.util.Date

internal object Serializer {
    @JvmStatic
    val moshiBuilder: Moshi.Builder = Moshi.Builder()
        .add(OffsetDateTimeAdapter())
        .add(LocalDateTimeAdapter())
        .add(LocalDateAdapter())
        .add(UUIDAdapter())
        .add(ByteArrayAdapter())
        .add(UriAdapter())
        .add(KotlinJsonAdapterFactory())
        .add(BigDecimalAdapter())
        .add(BigIntegerAdapter())

    @JvmStatic
    val moshi: Moshi by lazy {
        moshiBuilder.build()
    }
}