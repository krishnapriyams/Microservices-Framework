using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Synergy.Communication.EventService.Models.Entities
{
    public class AppIdentity
    {
        /// <summary>
        /// The application id uniquely identifies the application context within which the data transfer.
        /// </summary>
        public string ApplicationId { get; set; }

        /// <summary>
        /// The tenant id uniquely identifies the tenant context within which the data transfer takes place
        /// </summary>
        public string TenantId { get; set; }

        /// <summary>
        /// The vessel id uniquely identifies the vessel context within which the data transfer.
        /// </summary>
        public string VesselId { get; set; }
    }
}
