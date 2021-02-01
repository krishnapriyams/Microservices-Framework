using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Synergy.Communication.EventService.Models.Constants
{
    public enum EventStatus
    {
        New = 0,
        Sent = 1,
        Received = 2,
        Processed = 3,
        Orphan = 4, 
        Deleted = 5
    }
}
