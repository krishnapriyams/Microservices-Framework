using Synergy.Communication.EventService.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Synergy.Communication.EventService.Repository.Interfaces
{
    public interface IEventRepository
    {
        /// <summary>
        /// Get all events
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Event>> GetEvents();

        /// <summary>
        /// Get events by id
        /// </summary>
        /// <param name="eventId">36 character long UUID</param>
        /// <returns></returns>
        Task<Event> GetEventById(string eventId);

        /// <summary>
        /// Insert event to the datastore
        /// </summary>
        /// <param name="event"></param>
        Task InsertEvent(Event @event);

        /// <summary>
        /// Delete event from the datastore
        /// </summary>
        /// <param name="eventId"></param>
        Task DeleteEvent(string eventId);

        /// <summary>
        /// Update event in the datastore
        /// </summary>
        /// <param name="event"></param>
        Task UpdateEvent(Event @event);

        /// <summary>
        /// Commit changes to the datastore
        /// </summary>
        Task Save();

    }
}
