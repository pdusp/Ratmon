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


namespace IO.Swagger.Model
{
    /// <summary>
    /// AllCircuitsDetector
    /// </summary>
    [DataContract]
        public partial class AllCircuitsDetector :  IEquatable<AllCircuitsDetector>, IValidatableObject
    {
        /// <summary>
        /// Defines BatteryState
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum BatteryStateEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            [EnumMember(Value = "0")]
            NUMBER_0 = 1,
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            [EnumMember(Value = "1")]
            NUMBER_1 = 2,
            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            [EnumMember(Value = "2")]
            NUMBER_2 = 3        }
        /// <summary>
        /// Gets or Sets BatteryState
        /// </summary>
        [DataMember(Name="Battery_State", EmitDefaultValue=false)]
        public BatteryStateEnum? BatteryState { get; set; }
        /// <summary>
        /// Defines GSMState
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum GSMStateEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            [EnumMember(Value = "0")]
            NUMBER_0 = 1,
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            [EnumMember(Value = "1")]
            NUMBER_1 = 2,
            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            [EnumMember(Value = "2")]
            NUMBER_2 = 3        }
        /// <summary>
        /// Gets or Sets GSMState
        /// </summary>
        [DataMember(Name="GSM_State", EmitDefaultValue=false)]
        public GSMStateEnum? GSMState { get; set; }
        /// <summary>
        /// Defines CommState
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum CommStateEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            [EnumMember(Value = "0")]
            NUMBER_0 = 1,
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            [EnumMember(Value = "1")]
            NUMBER_1 = 2,
            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            [EnumMember(Value = "2")]
            NUMBER_2 = 3        }
        /// <summary>
        /// Gets or Sets CommState
        /// </summary>
        [DataMember(Name="Comm_State", EmitDefaultValue=false)]
        public CommStateEnum? CommState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AllCircuitsDetector" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="batteryState">batteryState.</param>
        /// <param name="gSMState">gSMState.</param>
        /// <param name="commState">commState.</param>
        public AllCircuitsDetector(int? id = default(int?), BatteryStateEnum? batteryState = default(BatteryStateEnum?), GSMStateEnum? gSMState = default(GSMStateEnum?), CommStateEnum? commState = default(CommStateEnum?))
        {
            this.Id = id;
            this.BatteryState = batteryState;
            this.GSMState = gSMState;
            this.CommState = commState;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public int? Id { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AllCircuitsDetector {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BatteryState: ").Append(BatteryState).Append("\n");
            sb.Append("  GSMState: ").Append(GSMState).Append("\n");
            sb.Append("  CommState: ").Append(CommState).Append("\n");
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
            return this.Equals(input as AllCircuitsDetector);
        }

        /// <summary>
        /// Returns true if AllCircuitsDetector instances are equal
        /// </summary>
        /// <param name="input">Instance of AllCircuitsDetector to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AllCircuitsDetector input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.BatteryState == input.BatteryState ||
                    (this.BatteryState != null &&
                    this.BatteryState.Equals(input.BatteryState))
                ) && 
                (
                    this.GSMState == input.GSMState ||
                    (this.GSMState != null &&
                    this.GSMState.Equals(input.GSMState))
                ) && 
                (
                    this.CommState == input.CommState ||
                    (this.CommState != null &&
                    this.CommState.Equals(input.CommState))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.BatteryState != null)
                    hashCode = hashCode * 59 + this.BatteryState.GetHashCode();
                if (this.GSMState != null)
                    hashCode = hashCode * 59 + this.GSMState.GetHashCode();
                if (this.CommState != null)
                    hashCode = hashCode * 59 + this.CommState.GetHashCode();
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
