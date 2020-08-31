/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2.1
 * Contact: devcenter@docusign.com
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
using SwaggerDateConverter = DocuSign.eSign.Client.SwaggerDateConverter;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// ConditionalRecipientRule
    /// </summary>
    [DataContract]
    public partial class ConditionalRecipientRule :  IEquatable<ConditionalRecipientRule>, IValidatableObject
    {
        public ConditionalRecipientRule()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionalRecipientRule" /> class.
        /// </summary>
        /// <param name="Conditions">Conditions.</param>
        /// <param name="Order">Order.</param>
        /// <param name="RecipientGroup">RecipientGroup.</param>
        /// <param name="RecipientId">Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document..</param>
        public ConditionalRecipientRule(List<ConditionalRecipientRuleCondition> Conditions = default(List<ConditionalRecipientRuleCondition>), string Order = default(string), RecipientGroup RecipientGroup = default(RecipientGroup), string RecipientId = default(string))
        {
            this.Conditions = Conditions;
            this.Order = Order;
            this.RecipientGroup = RecipientGroup;
            this.RecipientId = RecipientId;
        }
        
        /// <summary>
        /// Gets or Sets Conditions
        /// </summary>
        [DataMember(Name="conditions", EmitDefaultValue=false)]
        public List<ConditionalRecipientRuleCondition> Conditions { get; set; }
        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public string Order { get; set; }
        /// <summary>
        /// Gets or Sets RecipientGroup
        /// </summary>
        [DataMember(Name="recipientGroup", EmitDefaultValue=false)]
        public RecipientGroup RecipientGroup { get; set; }
        /// <summary>
        /// Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document.
        /// </summary>
        /// <value>Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document.</value>
        [DataMember(Name="recipientId", EmitDefaultValue=false)]
        public string RecipientId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConditionalRecipientRule {\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  RecipientGroup: ").Append(RecipientGroup).Append("\n");
            sb.Append("  RecipientId: ").Append(RecipientId).Append("\n");
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
            return this.Equals(obj as ConditionalRecipientRule);
        }

        /// <summary>
        /// Returns true if ConditionalRecipientRule instances are equal
        /// </summary>
        /// <param name="other">Instance of ConditionalRecipientRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConditionalRecipientRule other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Conditions == other.Conditions ||
                    this.Conditions != null &&
                    this.Conditions.SequenceEqual(other.Conditions)
                ) && 
                (
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
                ) && 
                (
                    this.RecipientGroup == other.RecipientGroup ||
                    this.RecipientGroup != null &&
                    this.RecipientGroup.Equals(other.RecipientGroup)
                ) && 
                (
                    this.RecipientId == other.RecipientId ||
                    this.RecipientId != null &&
                    this.RecipientId.Equals(other.RecipientId)
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
                if (this.Conditions != null)
                    hash = hash * 59 + this.Conditions.GetHashCode();
                if (this.Order != null)
                    hash = hash * 59 + this.Order.GetHashCode();
                if (this.RecipientGroup != null)
                    hash = hash * 59 + this.RecipientGroup.GetHashCode();
                if (this.RecipientId != null)
                    hash = hash * 59 + this.RecipientId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
