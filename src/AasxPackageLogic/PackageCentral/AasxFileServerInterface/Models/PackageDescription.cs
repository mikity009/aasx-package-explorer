/*
 * DotAAS Part 2 | HTTP/REST | AASX File Server Service Specification
 *
 * The File Server Service Specification as part of the [Specification of the Asset Administration Shell: Part 2](http://industrialdigitaltwin.org/en/content-hub).   Publisher: Industrial Digital Twin Association (IDTA) 2023
 *
 * OpenAPI spec version: V3.0.1_SSP-001
 * Contact: info@idtwin.org
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace AasxPackageLogic.PackageCentral.AasxFileServerInterface.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class PackageDescription
    {
        /// <summary>
        /// Gets or Sets AasIds
        /// </summary>

        [DataMember(Name = "aasIds")]
        public List<string> AasIds { get; set; }

        /// <summary>
        /// Gets or Sets PackageId
        /// </summary>

        [MaxLength(128)]
        [DataMember(Name = "packageId")]
        public string PackageId { get; set; }

    }
}
