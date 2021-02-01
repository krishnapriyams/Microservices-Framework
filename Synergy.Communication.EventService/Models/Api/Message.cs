using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Synergy.Communication.EventService.Models.Api
{
    public class Message
    {
        [DataMember(Name = "Id")]
        [StringLength(36, ErrorMessage = "The field 'MessageId' must be a string with a maximum length of '36'.")]
        public string MessageId { get; set; }

        [DataMember(Name = "identity")]
        [Required] 
        public AppIdentity Identity { get; set; }

        [DataMember(Name = "data")]
        [Required] 
        public JToken Data { get; set; }
    }
}
