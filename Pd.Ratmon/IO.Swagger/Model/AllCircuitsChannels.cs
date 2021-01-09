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
    /// AllCircuitsChannels
    /// </summary>
    [DataContract]
        public partial class AllCircuitsChannels :  IEquatable<AllCircuitsChannels>, IValidatableObject
    {
        /// <summary>
        /// Defines State
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StateEnum
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
            NUMBER_2 = 3,
            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            [EnumMember(Value = "4")]
            NUMBER_4 = 4,
            /// <summary>
            /// Enum NUMBER_8 for value: 8
            /// </summary>
            [EnumMember(Value = "8")]
            NUMBER_8 = 5        }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="State", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Defines AlarmType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum AlarmTypeEnum
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
            NUMBER_2 = 3,
            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            [EnumMember(Value = "3")]
            NUMBER_3 = 4        }
        /// <summary>
        /// Gets or Sets AlarmType
        /// </summary>
        [DataMember(Name="AlarmType", EmitDefaultValue=false)]
        public AlarmTypeEnum? AlarmType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AllCircuitsChannels" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="state">state.</param>
        /// <param name="alarmType">alarmType.</param>
        public AllCircuitsChannels(int? id = default(int?), string name = default(string), StateEnum? state = default(StateEnum?), AlarmTypeEnum? alarmType = default(AlarmTypeEnum?))
        {
            this.Id = id;
            this.Name = name;
            this.State = state;
            this.AlarmType = alarmType;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AllCircuitsChannels {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  AlarmType: ").Append(AlarmType).Append("\n");
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
            return this.Equals(input as AllCircuitsChannels);
        }

        /// <summary>
        /// Returns true if AllCircuitsChannels instances are equal
        /// </summary>
        /// <param name="input">Instance of AllCircuitsChannels to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AllCircuitsChannels input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.AlarmType == input.AlarmType ||
                    (this.AlarmType != null &&
                    this.AlarmType.Equals(input.AlarmType))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.AlarmType != null)
                    hashCode = hashCode * 59 + this.AlarmType.GetHashCode();
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