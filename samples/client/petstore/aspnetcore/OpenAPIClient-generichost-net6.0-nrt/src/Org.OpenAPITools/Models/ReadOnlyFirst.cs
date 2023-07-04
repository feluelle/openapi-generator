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
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Org.OpenAPITools.Converters;

namespace Org.OpenAPITools.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class ReadOnlyFirst : IEquatable<ReadOnlyFirst>
    {
        /// <summary>
        /// Gets or Sets Bar
        /// </summary>
        [DataMember(Name="bar", EmitDefaultValue=false)]
        public string Bar { get; set; }

        /// <summary>
        /// Gets or Sets Baz
        /// </summary>
        [DataMember(Name="baz", EmitDefaultValue=false)]
        public string Baz { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReadOnlyFirst {\n");
            sb.Append("  Bar: ").Append(Bar).Append("\n");
            sb.Append("  Baz: ").Append(Baz).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((ReadOnlyFirst)obj);
        }

        /// <summary>
        /// Returns true if ReadOnlyFirst instances are equal
        /// </summary>
        /// <param name="other">Instance of ReadOnlyFirst to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReadOnlyFirst other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Bar == other.Bar ||
                    Bar != null &&
                    Bar.Equals(other.Bar)
                ) && 
                (
                    Baz == other.Baz ||
                    Baz != null &&
                    Baz.Equals(other.Baz)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Bar != null)
                    hashCode = hashCode * 59 + Bar.GetHashCode();
                    if (Baz != null)
                    hashCode = hashCode * 59 + Baz.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ReadOnlyFirst left, ReadOnlyFirst right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ReadOnlyFirst left, ReadOnlyFirst right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
