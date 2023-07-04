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
    public partial class ChildCat : ParentPet, IEquatable<ChildCat>
    {
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Gets or Sets PetType
        /// </summary>
        [TypeConverter(typeof(CustomEnumConverter<PetTypeEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum PetTypeEnum
        {
            
            /// <summary>
            /// Enum ChildCatEnum for ChildCat
            /// </summary>
            [EnumMember(Value = "ChildCat")]
            ChildCatEnum = 1
        }

        /// <summary>
        /// Gets or Sets PetType
        /// </summary>
        [DataMember(Name="pet_type", EmitDefaultValue=true)]
        public PetTypeEnum PetType { get; set; } = PetTypeEnum.ChildCatEnum;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChildCat {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PetType: ").Append(PetType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public new string ToJson()
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
            return obj.GetType() == GetType() && Equals((ChildCat)obj);
        }

        /// <summary>
        /// Returns true if ChildCat instances are equal
        /// </summary>
        /// <param name="other">Instance of ChildCat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChildCat other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    PetType == other.PetType ||
                    
                    PetType.Equals(other.PetType)
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
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    
                    hashCode = hashCode * 59 + PetType.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ChildCat left, ChildCat right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ChildCat left, ChildCat right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
