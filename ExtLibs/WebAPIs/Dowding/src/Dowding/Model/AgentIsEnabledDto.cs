/* 
 * Dowding HTTP REST API
 *
 * The Dowding HTTP REST API allows you to add and retrieve contact data from Dowding as well as perform other peripheral functions.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Dowding.Model
{
    /// <summary>
    /// AgentIsEnabledDto
    /// </summary>
    [DataContract]
    public partial class AgentIsEnabledDto :  IEquatable<AgentIsEnabledDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentIsEnabledDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgentIsEnabledDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentIsEnabledDto" /> class.
        /// </summary>
        /// <param name="IsEnabled">Boolean signifying data is allowed to stream to/from this agent (required).</param>
        public AgentIsEnabledDto(bool? IsEnabled = null)
        {
            // to ensure "IsEnabled" is required (not null)
            if (IsEnabled == null)
            {
                throw new InvalidDataException("IsEnabled is a required property for AgentIsEnabledDto and cannot be null");
            }
            else
            {
                this.IsEnabled = IsEnabled;
            }
        }
        
        /// <summary>
        /// Boolean signifying data is allowed to stream to/from this agent
        /// </summary>
        /// <value>Boolean signifying data is allowed to stream to/from this agent</value>
        [DataMember(Name="is_enabled", EmitDefaultValue=false)]
        public bool? IsEnabled { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentIsEnabledDto {\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
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
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as AgentIsEnabledDto);
        }

        /// <summary>
        /// Returns true if AgentIsEnabledDto instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentIsEnabledDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentIsEnabledDto other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IsEnabled == other.IsEnabled ||
                    this.IsEnabled != null &&
                    this.IsEnabled.Equals(other.IsEnabled)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.IsEnabled != null)
                    hash = hash * 59 + this.IsEnabled.GetHashCode();
                return hash;
            }
        }
    }

}