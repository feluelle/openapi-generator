package org.openapitools.model;

import java.net.URI;
import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonIgnoreProperties;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonSubTypes;
import com.fasterxml.jackson.annotation.JsonTypeInfo;
import org.openapitools.model.Foo;
import org.openapitools.model.FooRef;
import org.openapitools.model.RefOrValueEnum;
import org.openapitools.jackson.nullable.JsonNullable;
import java.time.OffsetDateTime;
import javax.validation.Valid;
import javax.validation.constraints.*;
import io.swagger.v3.oas.annotations.media.Schema;


import java.util.*;
import javax.annotation.Generated;


@JsonIgnoreProperties(
  value = "objectType", // ignore manually set objectType, it will be automatically generated by Jackson during serialization
  allowSetters = true // allows the objectType to be set during deserialization
)
@JsonTypeInfo(use = JsonTypeInfo.Id.NAME, include = JsonTypeInfo.As.PROPERTY, property = "objectType", visible = true)
@JsonSubTypes({
  @JsonSubTypes.Type(value = Foo.class, name = "Foo"),
  @JsonSubTypes.Type(value = FooRef.class, name = "FooRef"),
  @JsonSubTypes.Type(value = FooRef.class, name = "REF"),
  @JsonSubTypes.Type(value = Foo.class, name = "VALUE")
})

@Generated(value = "org.openapitools.codegen.languages.SpringCodegen")
public interface FooRefOrValueEnumMapping {
    public RefOrValueEnum getObjectType();
}
