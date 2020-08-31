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
    /// ReportInProductSentByDetails
    /// </summary>
    [DataContract]
    public partial class ReportInProductSentByDetails :  IEquatable<ReportInProductSentByDetails>, IValidatableObject
    {
        public ReportInProductSentByDetails()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportInProductSentByDetails" /> class.
        /// </summary>
        /// <param name="Groups">A collection group objects containing information about the groups returned..</param>
        /// <param name="Users">Users.</param>
        public ReportInProductSentByDetails(List<Group> Groups = default(List<Group>), List<UserInfo> Users = default(List<UserInfo>))
        {
            this.Groups = Groups;
            this.Users = Users;
        }
        
        /// <summary>
        /// A collection group objects containing information about the groups returned.
        /// </summary>
        /// <value>A collection group objects containing information about the groups returned.</value>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<Group> Groups { get; set; }
        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<UserInfo> Users { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportInProductSentByDetails {\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
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
            return this.Equals(obj as ReportInProductSentByDetails);
        }

        /// <summary>
        /// Returns true if ReportInProductSentByDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportInProductSentByDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportInProductSentByDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Groups == other.Groups ||
                    this.Groups != null &&
                    this.Groups.SequenceEqual(other.Groups)
                ) && 
                (
                    this.Users == other.Users ||
                    this.Users != null &&
                    this.Users.SequenceEqual(other.Users)
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
                if (this.Groups != null)
                    hash = hash * 59 + this.Groups.GetHashCode();
                if (this.Users != null)
                    hash = hash * 59 + this.Users.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
