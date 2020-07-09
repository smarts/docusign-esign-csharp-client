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
    /// Comment
    /// </summary>
    [DataContract]
    public partial class Comment :  IEquatable<Comment>, IValidatableObject
    {
        public Comment()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Comment" /> class.
        /// </summary>
        /// <param name="EnvelopeId">The envelope ID of the envelope status that failed to post..</param>
        /// <param name="Hmac">Hmac.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Mentions">Mentions.</param>
        /// <param name="Read">Read.</param>
        /// <param name="SentByEmail">SentByEmail.</param>
        /// <param name="SentByFullName">SentByFullName.</param>
        /// <param name="SentByImageId">SentByImageId.</param>
        /// <param name="SentByInitials">SentByInitials.</param>
        /// <param name="SentByRecipientId">SentByRecipientId.</param>
        /// <param name="SentByUserId">SentByUserId.</param>
        /// <param name="SigningGroupId">When set to **true** and the feature is enabled in the sender&#39;s account, the signing recipient is required to draw signatures and initials at each signature/initial tab ( instead of adopting a signature/initial style or only drawing a signature/initial once)..</param>
        /// <param name="SigningGroupName">The display name for the signing group.   Maximum Length: 100 characters. .</param>
        /// <param name="Subject">Subject.</param>
        /// <param name="TabId">The unique identifier for the tab. The tabid can be retrieved with the [ML:GET call].     .</param>
        /// <param name="Text">Text.</param>
        /// <param name="ThreadId">ThreadId.</param>
        /// <param name="ThreadOriginatorId">ThreadOriginatorId.</param>
        /// <param name="Timestamp">Timestamp.</param>
        /// <param name="TimeStampFormatted">TimeStampFormatted.</param>
        /// <param name="VisibleTo">VisibleTo.</param>
        public Comment(string EnvelopeId = default(string), string Hmac = default(string), string Id = default(string), List<string> Mentions = default(List<string>), bool? Read = default(bool?), string SentByEmail = default(string), string SentByFullName = default(string), string SentByImageId = default(string), string SentByInitials = default(string), string SentByRecipientId = default(string), string SentByUserId = default(string), string SigningGroupId = default(string), string SigningGroupName = default(string), string Subject = default(string), string TabId = default(string), string Text = default(string), string ThreadId = default(string), string ThreadOriginatorId = default(string), string Timestamp = default(string), string TimeStampFormatted = default(string), List<string> VisibleTo = default(List<string>))
        {
            this.EnvelopeId = EnvelopeId;
            this.Hmac = Hmac;
            this.Id = Id;
            this.Mentions = Mentions;
            this.Read = Read;
            this.SentByEmail = SentByEmail;
            this.SentByFullName = SentByFullName;
            this.SentByImageId = SentByImageId;
            this.SentByInitials = SentByInitials;
            this.SentByRecipientId = SentByRecipientId;
            this.SentByUserId = SentByUserId;
            this.SigningGroupId = SigningGroupId;
            this.SigningGroupName = SigningGroupName;
            this.Subject = Subject;
            this.TabId = TabId;
            this.Text = Text;
            this.ThreadId = ThreadId;
            this.ThreadOriginatorId = ThreadOriginatorId;
            this.Timestamp = Timestamp;
            this.TimeStampFormatted = TimeStampFormatted;
            this.VisibleTo = VisibleTo;
        }
        
        /// <summary>
        /// The envelope ID of the envelope status that failed to post.
        /// </summary>
        /// <value>The envelope ID of the envelope status that failed to post.</value>
        [DataMember(Name="envelopeId", EmitDefaultValue=false)]
        public string EnvelopeId { get; set; }
        /// <summary>
        /// Gets or Sets Hmac
        /// </summary>
        [DataMember(Name="hmac", EmitDefaultValue=false)]
        public string Hmac { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Mentions
        /// </summary>
        [DataMember(Name="mentions", EmitDefaultValue=false)]
        public List<string> Mentions { get; set; }
        /// <summary>
        /// Gets or Sets Read
        /// </summary>
        [DataMember(Name="read", EmitDefaultValue=false)]
        public bool? Read { get; set; }
        /// <summary>
        /// Gets or Sets SentByEmail
        /// </summary>
        [DataMember(Name="sentByEmail", EmitDefaultValue=false)]
        public string SentByEmail { get; set; }
        /// <summary>
        /// Gets or Sets SentByFullName
        /// </summary>
        [DataMember(Name="sentByFullName", EmitDefaultValue=false)]
        public string SentByFullName { get; set; }
        /// <summary>
        /// Gets or Sets SentByImageId
        /// </summary>
        [DataMember(Name="sentByImageId", EmitDefaultValue=false)]
        public string SentByImageId { get; set; }
        /// <summary>
        /// Gets or Sets SentByInitials
        /// </summary>
        [DataMember(Name="sentByInitials", EmitDefaultValue=false)]
        public string SentByInitials { get; set; }
        /// <summary>
        /// Gets or Sets SentByRecipientId
        /// </summary>
        [DataMember(Name="sentByRecipientId", EmitDefaultValue=false)]
        public string SentByRecipientId { get; set; }
        /// <summary>
        /// Gets or Sets SentByUserId
        /// </summary>
        [DataMember(Name="sentByUserId", EmitDefaultValue=false)]
        public string SentByUserId { get; set; }
        /// <summary>
        /// When set to **true** and the feature is enabled in the sender&#39;s account, the signing recipient is required to draw signatures and initials at each signature/initial tab ( instead of adopting a signature/initial style or only drawing a signature/initial once).
        /// </summary>
        /// <value>When set to **true** and the feature is enabled in the sender&#39;s account, the signing recipient is required to draw signatures and initials at each signature/initial tab ( instead of adopting a signature/initial style or only drawing a signature/initial once).</value>
        [DataMember(Name="signingGroupId", EmitDefaultValue=false)]
        public string SigningGroupId { get; set; }
        /// <summary>
        /// The display name for the signing group.   Maximum Length: 100 characters. 
        /// </summary>
        /// <value>The display name for the signing group.   Maximum Length: 100 characters. </value>
        [DataMember(Name="signingGroupName", EmitDefaultValue=false)]
        public string SigningGroupName { get; set; }
        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }
        /// <summary>
        /// The unique identifier for the tab. The tabid can be retrieved with the [ML:GET call].     
        /// </summary>
        /// <value>The unique identifier for the tab. The tabid can be retrieved with the [ML:GET call].     </value>
        [DataMember(Name="tabId", EmitDefaultValue=false)]
        public string TabId { get; set; }
        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }
        /// <summary>
        /// Gets or Sets ThreadId
        /// </summary>
        [DataMember(Name="threadId", EmitDefaultValue=false)]
        public string ThreadId { get; set; }
        /// <summary>
        /// Gets or Sets ThreadOriginatorId
        /// </summary>
        [DataMember(Name="threadOriginatorId", EmitDefaultValue=false)]
        public string ThreadOriginatorId { get; set; }
        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public string Timestamp { get; set; }
        /// <summary>
        /// Gets or Sets TimeStampFormatted
        /// </summary>
        [DataMember(Name="timeStampFormatted", EmitDefaultValue=false)]
        public string TimeStampFormatted { get; set; }
        /// <summary>
        /// Gets or Sets VisibleTo
        /// </summary>
        [DataMember(Name="visibleTo", EmitDefaultValue=false)]
        public List<string> VisibleTo { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Comment {\n");
            sb.Append("  EnvelopeId: ").Append(EnvelopeId).Append("\n");
            sb.Append("  Hmac: ").Append(Hmac).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Mentions: ").Append(Mentions).Append("\n");
            sb.Append("  Read: ").Append(Read).Append("\n");
            sb.Append("  SentByEmail: ").Append(SentByEmail).Append("\n");
            sb.Append("  SentByFullName: ").Append(SentByFullName).Append("\n");
            sb.Append("  SentByImageId: ").Append(SentByImageId).Append("\n");
            sb.Append("  SentByInitials: ").Append(SentByInitials).Append("\n");
            sb.Append("  SentByRecipientId: ").Append(SentByRecipientId).Append("\n");
            sb.Append("  SentByUserId: ").Append(SentByUserId).Append("\n");
            sb.Append("  SigningGroupId: ").Append(SigningGroupId).Append("\n");
            sb.Append("  SigningGroupName: ").Append(SigningGroupName).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  TabId: ").Append(TabId).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  ThreadId: ").Append(ThreadId).Append("\n");
            sb.Append("  ThreadOriginatorId: ").Append(ThreadOriginatorId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  TimeStampFormatted: ").Append(TimeStampFormatted).Append("\n");
            sb.Append("  VisibleTo: ").Append(VisibleTo).Append("\n");
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
            return this.Equals(obj as Comment);
        }

        /// <summary>
        /// Returns true if Comment instances are equal
        /// </summary>
        /// <param name="other">Instance of Comment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Comment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EnvelopeId == other.EnvelopeId ||
                    this.EnvelopeId != null &&
                    this.EnvelopeId.Equals(other.EnvelopeId)
                ) && 
                (
                    this.Hmac == other.Hmac ||
                    this.Hmac != null &&
                    this.Hmac.Equals(other.Hmac)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Mentions == other.Mentions ||
                    this.Mentions != null &&
                    this.Mentions.SequenceEqual(other.Mentions)
                ) && 
                (
                    this.Read == other.Read ||
                    this.Read != null &&
                    this.Read.Equals(other.Read)
                ) && 
                (
                    this.SentByEmail == other.SentByEmail ||
                    this.SentByEmail != null &&
                    this.SentByEmail.Equals(other.SentByEmail)
                ) && 
                (
                    this.SentByFullName == other.SentByFullName ||
                    this.SentByFullName != null &&
                    this.SentByFullName.Equals(other.SentByFullName)
                ) && 
                (
                    this.SentByImageId == other.SentByImageId ||
                    this.SentByImageId != null &&
                    this.SentByImageId.Equals(other.SentByImageId)
                ) && 
                (
                    this.SentByInitials == other.SentByInitials ||
                    this.SentByInitials != null &&
                    this.SentByInitials.Equals(other.SentByInitials)
                ) && 
                (
                    this.SentByRecipientId == other.SentByRecipientId ||
                    this.SentByRecipientId != null &&
                    this.SentByRecipientId.Equals(other.SentByRecipientId)
                ) && 
                (
                    this.SentByUserId == other.SentByUserId ||
                    this.SentByUserId != null &&
                    this.SentByUserId.Equals(other.SentByUserId)
                ) && 
                (
                    this.SigningGroupId == other.SigningGroupId ||
                    this.SigningGroupId != null &&
                    this.SigningGroupId.Equals(other.SigningGroupId)
                ) && 
                (
                    this.SigningGroupName == other.SigningGroupName ||
                    this.SigningGroupName != null &&
                    this.SigningGroupName.Equals(other.SigningGroupName)
                ) && 
                (
                    this.Subject == other.Subject ||
                    this.Subject != null &&
                    this.Subject.Equals(other.Subject)
                ) && 
                (
                    this.TabId == other.TabId ||
                    this.TabId != null &&
                    this.TabId.Equals(other.TabId)
                ) && 
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) && 
                (
                    this.ThreadId == other.ThreadId ||
                    this.ThreadId != null &&
                    this.ThreadId.Equals(other.ThreadId)
                ) && 
                (
                    this.ThreadOriginatorId == other.ThreadOriginatorId ||
                    this.ThreadOriginatorId != null &&
                    this.ThreadOriginatorId.Equals(other.ThreadOriginatorId)
                ) && 
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    this.TimeStampFormatted == other.TimeStampFormatted ||
                    this.TimeStampFormatted != null &&
                    this.TimeStampFormatted.Equals(other.TimeStampFormatted)
                ) && 
                (
                    this.VisibleTo == other.VisibleTo ||
                    this.VisibleTo != null &&
                    this.VisibleTo.SequenceEqual(other.VisibleTo)
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
                if (this.EnvelopeId != null)
                    hash = hash * 59 + this.EnvelopeId.GetHashCode();
                if (this.Hmac != null)
                    hash = hash * 59 + this.Hmac.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Mentions != null)
                    hash = hash * 59 + this.Mentions.GetHashCode();
                if (this.Read != null)
                    hash = hash * 59 + this.Read.GetHashCode();
                if (this.SentByEmail != null)
                    hash = hash * 59 + this.SentByEmail.GetHashCode();
                if (this.SentByFullName != null)
                    hash = hash * 59 + this.SentByFullName.GetHashCode();
                if (this.SentByImageId != null)
                    hash = hash * 59 + this.SentByImageId.GetHashCode();
                if (this.SentByInitials != null)
                    hash = hash * 59 + this.SentByInitials.GetHashCode();
                if (this.SentByRecipientId != null)
                    hash = hash * 59 + this.SentByRecipientId.GetHashCode();
                if (this.SentByUserId != null)
                    hash = hash * 59 + this.SentByUserId.GetHashCode();
                if (this.SigningGroupId != null)
                    hash = hash * 59 + this.SigningGroupId.GetHashCode();
                if (this.SigningGroupName != null)
                    hash = hash * 59 + this.SigningGroupName.GetHashCode();
                if (this.Subject != null)
                    hash = hash * 59 + this.Subject.GetHashCode();
                if (this.TabId != null)
                    hash = hash * 59 + this.TabId.GetHashCode();
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();
                if (this.ThreadId != null)
                    hash = hash * 59 + this.ThreadId.GetHashCode();
                if (this.ThreadOriginatorId != null)
                    hash = hash * 59 + this.ThreadOriginatorId.GetHashCode();
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                if (this.TimeStampFormatted != null)
                    hash = hash * 59 + this.TimeStampFormatted.GetHashCode();
                if (this.VisibleTo != null)
                    hash = hash * 59 + this.VisibleTo.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}