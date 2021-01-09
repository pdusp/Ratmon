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
    /// SelectedChannelResThresholds
    /// </summary>
    [DataContract]
        public partial class SelectedChannelResThresholds :  IEquatable<SelectedChannelResThresholds>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectedChannelResThresholds" /> class.
        /// </summary>
        /// <param name="r1Alarm">r1Alarm.</param>
        /// <param name="r2Alarm">r2Alarm.</param>
        /// <param name="rLoopAlarm">rLoopAlarm.</param>
        /// <param name="r1Alert">r1Alert.</param>
        /// <param name="r2Alert">r2Alert.</param>
        /// <param name="rLoopAlert">rLoopAlert.</param>
        public SelectedChannelResThresholds(string r1Alarm = default(string), string r2Alarm = default(string), string rLoopAlarm = default(string), string r1Alert = default(string), string r2Alert = default(string), string rLoopAlert = default(string))
        {
            this.R1Alarm = r1Alarm;
            this.R2Alarm = r2Alarm;
            this.RLoopAlarm = rLoopAlarm;
            this.R1Alert = r1Alert;
            this.R2Alert = r2Alert;
            this.RLoopAlert = rLoopAlert;
        }
        
        /// <summary>
        /// Gets or Sets R1Alarm
        /// </summary>
        [DataMember(Name="R1_Alarm", EmitDefaultValue=false)]
        public string R1Alarm { get; set; }

        /// <summary>
        /// Gets or Sets R2Alarm
        /// </summary>
        [DataMember(Name="R2_Alarm", EmitDefaultValue=false)]
        public string R2Alarm { get; set; }

        /// <summary>
        /// Gets or Sets RLoopAlarm
        /// </summary>
        [DataMember(Name="RLoop_Alarm", EmitDefaultValue=false)]
        public string RLoopAlarm { get; set; }

        /// <summary>
        /// Gets or Sets R1Alert
        /// </summary>
        [DataMember(Name="R1_Alert", EmitDefaultValue=false)]
        public string R1Alert { get; set; }

        /// <summary>
        /// Gets or Sets R2Alert
        /// </summary>
        [DataMember(Name="R2_Alert", EmitDefaultValue=false)]
        public string R2Alert { get; set; }

        /// <summary>
        /// Gets or Sets RLoopAlert
        /// </summary>
        [DataMember(Name="RLoop_Alert", EmitDefaultValue=false)]
        public string RLoopAlert { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SelectedChannelResThresholds {\n");
            sb.Append("  R1Alarm: ").Append(R1Alarm).Append("\n");
            sb.Append("  R2Alarm: ").Append(R2Alarm).Append("\n");
            sb.Append("  RLoopAlarm: ").Append(RLoopAlarm).Append("\n");
            sb.Append("  R1Alert: ").Append(R1Alert).Append("\n");
            sb.Append("  R2Alert: ").Append(R2Alert).Append("\n");
            sb.Append("  RLoopAlert: ").Append(RLoopAlert).Append("\n");
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
            return this.Equals(input as SelectedChannelResThresholds);
        }

        /// <summary>
        /// Returns true if SelectedChannelResThresholds instances are equal
        /// </summary>
        /// <param name="input">Instance of SelectedChannelResThresholds to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SelectedChannelResThresholds input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.R1Alarm == input.R1Alarm ||
                    (this.R1Alarm != null &&
                    this.R1Alarm.Equals(input.R1Alarm))
                ) && 
                (
                    this.R2Alarm == input.R2Alarm ||
                    (this.R2Alarm != null &&
                    this.R2Alarm.Equals(input.R2Alarm))
                ) && 
                (
                    this.RLoopAlarm == input.RLoopAlarm ||
                    (this.RLoopAlarm != null &&
                    this.RLoopAlarm.Equals(input.RLoopAlarm))
                ) && 
                (
                    this.R1Alert == input.R1Alert ||
                    (this.R1Alert != null &&
                    this.R1Alert.Equals(input.R1Alert))
                ) && 
                (
                    this.R2Alert == input.R2Alert ||
                    (this.R2Alert != null &&
                    this.R2Alert.Equals(input.R2Alert))
                ) && 
                (
                    this.RLoopAlert == input.RLoopAlert ||
                    (this.RLoopAlert != null &&
                    this.RLoopAlert.Equals(input.RLoopAlert))
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
                if (this.R1Alarm != null)
                    hashCode = hashCode * 59 + this.R1Alarm.GetHashCode();
                if (this.R2Alarm != null)
                    hashCode = hashCode * 59 + this.R2Alarm.GetHashCode();
                if (this.RLoopAlarm != null)
                    hashCode = hashCode * 59 + this.RLoopAlarm.GetHashCode();
                if (this.R1Alert != null)
                    hashCode = hashCode * 59 + this.R1Alert.GetHashCode();
                if (this.R2Alert != null)
                    hashCode = hashCode * 59 + this.R2Alert.GetHashCode();
                if (this.RLoopAlert != null)
                    hashCode = hashCode * 59 + this.RLoopAlert.GetHashCode();
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
