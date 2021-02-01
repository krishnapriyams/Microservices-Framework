using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Synergy.Communication.EventService.Models.Api
{
    public class AppIdentity
    {
        [DataMember(Name = "appId")]
        [StringLength(36, ErrorMessage = "The field 'MessageId' must be a string with a maximum length of '36'.")] 
        [Required]
        public string ApplicationId { get; set; }

        [DataMember(Name = "tenantId")]
        [StringLength(36, ErrorMessage = "The field 'tenantId' must be a string with a maximum length of '36'.")]
        [Required]
        public string TenantId { get; set; }

        [DataMember(Name = "vesselId")]
        [StringLength(36, ErrorMessage = "The field 'vesselId' must be a string with a maximum length of '36'.")]
        [Required]
        public string VesselId { get; set; }
    }
}
