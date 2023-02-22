package org.openapitools.model

import java.util.Objects
import com.fasterxml.jackson.annotation.JsonProperty
import com.fasterxml.jackson.annotation.JsonValue
import org.openapitools.model.Category
import org.openapitools.model.Tag
import javax.validation.constraints.*
import javax.validation.Valid
import io.swagger.v3.oas.annotations.media.Schema

/**
 * A pet for sale in the pet store
 * @param name 
 * @param photoUrls 
 * @param id 
 * @param category 
 * @param tags 
 * @param status pet status in the store
 */
data class Pet(

    @Schema(example = "doggie", required = true, description = "")
    @get:JsonProperty("name", required = true) var name: kotlin.String,

    @Schema(example = "null", required = true, description = "")
    @get:JsonProperty("photoUrls", required = true) var photoUrls: kotlin.collections.MutableList<kotlin.String>,

    @Schema(example = "null", description = "")
    @get:JsonProperty("id") var id: kotlin.Long? = null,

    @field:Valid
    @Schema(example = "null", description = "")
    @get:JsonProperty("category") var category: Category? = null,

    @field:Valid
    @Schema(example = "null", description = "")
    @get:JsonProperty("tags") var tags: kotlin.collections.MutableList<Tag>? = null,

    @Schema(example = "null", description = "pet status in the store")
    @get:JsonProperty("status") var status: Pet.Status? = null
) {

    /**
    * pet status in the store
    * Values: available,pending,sold
    */
    enum class Status(val value: kotlin.String) {

        @JsonProperty("available") available("available"),
        @JsonProperty("pending") pending("pending"),
        @JsonProperty("sold") sold("sold")
    }

}

