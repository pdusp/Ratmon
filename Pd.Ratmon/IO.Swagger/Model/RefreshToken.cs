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
    /// RefreshToken
    /// </summary>
    [DataContract]
        public partial class RefreshToken :  IEquatable<RefreshToken>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefreshToken" /> class.
        /// </summary>
        /// <param name="token">token.</param>
        /// <param name="expiration">expiration.</param>
        /// <param name="refreshToken">refreshToken.</param>
        public RefreshToken(string token = default(string), int? expiration = default(int?), string refreshToken = default(string))
        {
            this.Token = token;
            this.Expiration = expiration;
            this._RefreshToken = refreshToken;
        }
        
        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name="Token", EmitDefaultValue=false)]
        public string Token { get; set; }

        /// <summary>
        /// Gets or Sets Expiration
        /// </summary>
        [DataMember(Name="Expiration", EmitDefaultValue=false)]
        public int? Expiration { get; set; }

        /// <summary>
        /// Gets or Sets _RefreshToken
        /// </summary>
        [DataMember(Name="RefreshToken", EmitDefaultValue=false)]
        public string _RefreshToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RefreshToken {\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            sb.Append("  _RefreshToken: ").Append(_RefreshToken).Append("\n");
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
            return this.Equals(input as RefreshToken);
        }

        /// <summary>
        /// Returns true if RefreshToken instances are equal
        /// </summary>
        /// <param name="input">Instance of RefreshToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RefreshToken input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.Expiration == input.Expiration ||
                    (this.Expiration != null &&
                    this.Expiration.Equals(input.Expiration))
                ) && 
                (
                    this._RefreshToken == input._RefreshToken ||
                    (this._RefreshToken != null &&
                    this._RefreshToken.Equals(input._RefreshToken))
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
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.Expiration != null)
                    hashCode = hashCode * 59 + this.Expiration.GetHashCode();
                if (this._RefreshToken != null)
                    hashCode = hashCode * 59 + this._RefreshToken.GetHashCode();
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