/* 
 * DotAAS Part 2 | HTTP/REST | Entire Interface Collection
 *
 * The entire interface collection as part of Details of the Asset Administration Shell Part 2
 *
 * OpenAPI spec version: Final-Draft
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Submodel
    /// </summary>
    [DataContract]
    public partial class Submodel : Identifiable, IEquatable<Submodel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Submodel" /> class.
        /// </summary>
        /// <param name="embeddedDataSpecifications">embeddedDataSpecifications.</param>
        /// <param name="qualifiers">qualifiers.</param>
        /// <param name="semanticId">semanticId.</param>
        /// <param name="kind">kind.</param>
        /// <param name="submodelElements">submodelElements.</param>
        public Submodel(List<EmbeddedDataSpecification> embeddedDataSpecifications = default(List<EmbeddedDataSpecification>), List<Constraint> qualifiers = default(List<Constraint>), Reference semanticId = default(Reference), ModelingKind kind = default(ModelingKind), List<SubmodelElement> submodelElements = default(List<SubmodelElement>), List<EmbeddedDataSpecification> embeddedDataSpecifications2 = default(List<EmbeddedDataSpecification>), AdministrativeInformation administration = default(AdministrativeInformation), string identification = default(string)) : base(administration, identification)
        {
            this.EmbeddedDataSpecifications = embeddedDataSpecifications;
            this.Qualifiers = qualifiers;
            this.SemanticId = semanticId;
            this.Kind = kind;
            this.SubmodelElements = submodelElements;
        }

        /// <summary>
        /// Gets or Sets EmbeddedDataSpecifications
        /// </summary>
        [DataMember(Name = "embeddedDataSpecifications", EmitDefaultValue = false)]
        public List<EmbeddedDataSpecification> EmbeddedDataSpecifications { get; set; }

        /// <summary>
        /// Gets or Sets Qualifiers
        /// </summary>
        [DataMember(Name = "qualifiers", EmitDefaultValue = false)]
        public List<Constraint> Qualifiers { get; set; }

        /// <summary>
        /// Gets or Sets SemanticId
        /// </summary>
        [DataMember(Name = "semanticId", EmitDefaultValue = false)]
        public Reference SemanticId { get; set; }

        /// <summary>
        /// Gets or Sets Kind
        /// </summary>
        [DataMember(Name = "kind", EmitDefaultValue = false)]
        public ModelingKind Kind { get; set; }

        /// <summary>
        /// Gets or Sets SubmodelElements
        /// </summary>
        [DataMember(Name = "submodelElements", EmitDefaultValue = false)]
        public List<SubmodelElement> SubmodelElements { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Submodel {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  EmbeddedDataSpecifications: ").Append(EmbeddedDataSpecifications).Append("\n");
            sb.Append("  Qualifiers: ").Append(Qualifiers).Append("\n");
            sb.Append("  SemanticId: ").Append(SemanticId).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  SubmodelElements: ").Append(SubmodelElements).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as Submodel);
        }

        /// <summary>
        /// Returns true if Submodel instances are equal
        /// </summary>
        /// <param name="input">Instance of Submodel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Submodel input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.EmbeddedDataSpecifications == input.EmbeddedDataSpecifications ||
                    this.EmbeddedDataSpecifications != null &&
                    input.EmbeddedDataSpecifications != null &&
                    this.EmbeddedDataSpecifications.SequenceEqual(input.EmbeddedDataSpecifications)
                ) && base.Equals(input) &&
                (
                    this.Qualifiers == input.Qualifiers ||
                    this.Qualifiers != null &&
                    input.Qualifiers != null &&
                    this.Qualifiers.SequenceEqual(input.Qualifiers)
                ) && base.Equals(input) &&
                (
                    this.SemanticId == input.SemanticId ||
                    (this.SemanticId != null &&
                    this.SemanticId.Equals(input.SemanticId))
                ) && base.Equals(input) &&
                (
                    this.Kind == input.Kind ||
                    (this.Kind != null &&
                    this.Kind.Equals(input.Kind))
                ) && base.Equals(input) &&
                (
                    this.SubmodelElements == input.SubmodelElements ||
                    this.SubmodelElements != null &&
                    input.SubmodelElements != null &&
                    this.SubmodelElements.SequenceEqual(input.SubmodelElements)
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
                int hashCode = base.GetHashCode();
                if (this.EmbeddedDataSpecifications != null)
                    hashCode = hashCode * 59 + this.EmbeddedDataSpecifications.GetHashCode();
                if (this.Qualifiers != null)
                    hashCode = hashCode * 59 + this.Qualifiers.GetHashCode();
                if (this.SemanticId != null)
                    hashCode = hashCode * 59 + this.SemanticId.GetHashCode();
                if (this.Kind != null)
                    hashCode = hashCode * 59 + this.Kind.GetHashCode();
                if (this.SubmodelElements != null)
                    hashCode = hashCode * 59 + this.SubmodelElements.GetHashCode();
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
