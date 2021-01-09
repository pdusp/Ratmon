/* 
 * API Ratmon
 *
 * API Ratmon
 *
 * OpenAPI spec version: 1.0.0-oas3
 * Contact: serwis@ratmon.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
//using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// SelectedChannel
    /// </summary>
    [DataContract]
        public partial class SelectedChannel :  IEquatable<SelectedChannel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectedChannel" /> class.
        /// </summary>
        /// <param name="channelId">channelId.</param>
        /// <param name="resistance">resistance.</param>
        /// <param name="resThresholds">resThresholds.</param>
        public SelectedChannel(int? channelId = default(int?), SelectedChannelResistance resistance = default(SelectedChannelResistance), SelectedChannelResThresholds resThresholds = default(SelectedChannelResThresholds))
        {
            this.ChannelId = channelId;
            this.Resistance = resistance;
            this.ResThresholds = resThresholds;
        }
        
        /// <summary>
        /// Gets or Sets ChannelId
        /// </summary>
        [DataMember(Name="ChannelId", EmitDefaultValue=false)]
        public int? ChannelId { get; set; }

        /// <summary>
        /// Gets or Sets Resistance
        /// </summary>
        [DataMember(Name="Resistance", EmitDefaultValue=false)]
        public SelectedChannelResistance Resistance { get; set; }

        /// <summary>
        /// Gets or Sets ResThresholds
        /// </summary>
        [DataMember(Name="ResThresholds", EmitDefaultValue=false)]
        public SelectedChannelResThresholds ResThresholds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SelectedChannel {\n");
            sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
            sb.Append("  Resistance: ").Append(Resistance).Append("\n");
            sb.Append("  ResThresholds: ").Append(ResThresholds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SelectedChannel);
        }

        /// <summary>
        /// Returns true if SelectedChannel instances are equal
        /// </summary>
        /// <param name="input">Instance of SelectedChannel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SelectedChannel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChannelId == input.ChannelId ||
                    (this.ChannelId != null &&
                    this.ChannelId.Equals(input.ChannelId))
                ) && 
                (
                    this.Resistance == input.Resistance ||
                    (this.Resistance != null &&
                    this.Resistance.Equals(input.Resistance))
                ) && 
                (
                    this.ResThresholds == input.ResThresholds ||
                    (this.ResThresholds != null &&
                    this.ResThresholds.Equals(input.ResThresholds))
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
                int hashCode = 41;
                if (this.ChannelId != null)
                    hashCode = hashCode * 59 + this.ChannelId.GetHashCode();
                if (this.Resistance != null)
                    hashCode = hashCode * 59 + this.Resistance.GetHashCode();
                if (this.ResThresholds != null)
                    hashCode = hashCode * 59 + this.ResThresholds.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
