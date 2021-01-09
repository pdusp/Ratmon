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
    /// BodyForRefreshToken
    /// </summary>
    [DataContract]
        public partial class BodyForRefreshToken :  IEquatable<BodyForRefreshToken>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BodyForRefreshToken" /> class.
        /// </summary>
        /// <param name="refreshToken">refreshToken.</param>
        public BodyForRefreshToken(string refreshToken = default(string))
        {
            this.RefreshToken = refreshToken;
        }
        
        /// <summary>
        /// Gets or Sets RefreshToken
        /// </summary>
        [DataMember(Name="refreshToken", EmitDefaultValue=false)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BodyForRefreshToken {\n");
            sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
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
            return this.Equals(input as BodyForRefreshToken);
        }

        /// <summary>
        /// Returns true if BodyForRefreshToken instances are equal
        /// </summary>
        /// <param name="input">Instance of BodyForRefreshToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BodyForRefreshToken input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RefreshToken == input.RefreshToken ||
                    (this.RefreshToken != null &&
                    this.RefreshToken.Equals(input.RefreshToken))
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
                if (this.RefreshToken != null)
                    hashCode = hashCode * 59 + this.RefreshToken.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult>
            IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}