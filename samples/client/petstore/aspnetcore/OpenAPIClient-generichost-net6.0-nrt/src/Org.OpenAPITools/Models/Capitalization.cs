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
    public partial class Capitalization : IEquatable<Capitalization>
    {
        /// <summary>
        /// Gets or Sets SmallCamel
        /// </summary>
        [DataMember(Name="smallCamel", EmitDefaultValue=false)]
        public string SmallCamel { get; set; }

        /// <summary>
        /// Gets or Sets CapitalCamel
        /// </summary>
        [DataMember(Name="CapitalCamel", EmitDefaultValue=false)]
        public string CapitalCamel { get; set; }

        /// <summary>
        /// Gets or Sets SmallSnake
        /// </summary>
        [DataMember(Name="small_Snake", EmitDefaultValue=false)]
        public string SmallSnake { get; set; }

        /// <summary>
        /// Gets or Sets CapitalSnake
        /// </summary>
        [DataMember(Name="Capital_Snake", EmitDefaultValue=false)]
        public string CapitalSnake { get; set; }

        /// <summary>
        /// Gets or Sets SCAETHFlowPoints
        /// </summary>
        [DataMember(Name="SCA_ETH_Flow_Points", EmitDefaultValue=false)]
        public string SCAETHFlowPoints { get; set; }

        /// <summary>
        /// Name of the pet 
        /// </summary>
        /// <value>Name of the pet </value>
        [DataMember(Name="ATT_NAME", EmitDefaultValue=false)]
        public string ATT_NAME { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Capitalization {\n");
            sb.Append("  SmallCamel: ").Append(SmallCamel).Append("\n");
            sb.Append("  CapitalCamel: ").Append(CapitalCamel).Append("\n");
            sb.Append("  SmallSnake: ").Append(SmallSnake).Append("\n");
            sb.Append("  CapitalSnake: ").Append(CapitalSnake).Append("\n");
            sb.Append("  SCAETHFlowPoints: ").Append(SCAETHFlowPoints).Append("\n");
            sb.Append("  ATT_NAME: ").Append(ATT_NAME).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Capitalization)obj);
        }

        /// <summary>
        /// Returns true if Capitalization instances are equal
        /// </summary>
        /// <param name="other">Instance of Capitalization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Capitalization other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    SmallCamel == other.SmallCamel ||
                    SmallCamel != null &&
                    SmallCamel.Equals(other.SmallCamel)
                ) && 
                (
                    CapitalCamel == other.CapitalCamel ||
                    CapitalCamel != null &&
                    CapitalCamel.Equals(other.CapitalCamel)
                ) && 
                (
                    SmallSnake == other.SmallSnake ||
                    SmallSnake != null &&
                    SmallSnake.Equals(other.SmallSnake)
                ) && 
                (
                    CapitalSnake == other.CapitalSnake ||
                    CapitalSnake != null &&
                    CapitalSnake.Equals(other.CapitalSnake)
                ) && 
                (
                    SCAETHFlowPoints == other.SCAETHFlowPoints ||
                    SCAETHFlowPoints != null &&
                    SCAETHFlowPoints.Equals(other.SCAETHFlowPoints)
                ) && 
                (
                    ATT_NAME == other.ATT_NAME ||
                    ATT_NAME != null &&
                    ATT_NAME.Equals(other.ATT_NAME)
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
                    if (SmallCamel != null)
                    hashCode = hashCode * 59 + SmallCamel.GetHashCode();
                    if (CapitalCamel != null)
                    hashCode = hashCode * 59 + CapitalCamel.GetHashCode();
                    if (SmallSnake != null)
                    hashCode = hashCode * 59 + SmallSnake.GetHashCode();
                    if (CapitalSnake != null)
                    hashCode = hashCode * 59 + CapitalSnake.GetHashCode();
                    if (SCAETHFlowPoints != null)
                    hashCode = hashCode * 59 + SCAETHFlowPoints.GetHashCode();
                    if (ATT_NAME != null)
                    hashCode = hashCode * 59 + ATT_NAME.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Capitalization left, Capitalization right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Capitalization left, Capitalization right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
