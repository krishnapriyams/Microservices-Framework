using Newtonsoft.Json.Linq;
using Synergy.Communication.EventService.Models.Constants;
using System;

namespace Synergy.Communication.EventService.Models.Entities
{
    public class Event
    {
        /// <summary>
        /// Event identifier will be a 36 character long UUID.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Application identifier will be a 36 character long UUID.
        /// </summary>
        public string ApplicationIdentifier { get; set; }

        /// <summary>
        /// The source attribute is used to identify the sender and receiver of the event
        /// </summary>
        public string Source { get; set; } = SourceType.Unknown.ToString();

        /// <summary>
        /// Event data received from the application.
        /// </summary>
        public JToken Data { get; set; }

        /// <summary>
        /// Created at timestamp in UTC
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Updated at timestamp in UTC
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Event type indicate the category of events
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Event status with the values New, Sent, Received, Processed, Orphan
        /// </summary>
        public string Status { get; set; } = EventStatus.New.ToString();
    }
}
