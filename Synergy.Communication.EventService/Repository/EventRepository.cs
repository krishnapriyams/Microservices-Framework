using Microsoft.EntityFrameworkCore;
using Synergy.Communication.EventService.DBContexts;
using Synergy.Communication.EventService.Models.Entities;
using Synergy.Communication.EventService.Repository.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Synergy.Communication.EventService.Repository
{
    public class EventRepository : IEventRepository
    {
        public readonly EventServiceDbContext _dbContext;
        public EventRepository(EventServiceDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task DeleteEvent(string eventId)
        {
            var eventRec = _dbContext.Events.Find(eventId);
            _dbContext.Events.Remove(eventRec);
            await Save();
        }

        public async Task<Event> GetEventById(string eventId)
        {
            return await _dbContext.Events.FindAsync(eventId);
        }

        public async Task<IEnumerable<Event>> GetEvents()
        {
            return await _dbContext.Events.ToListAsync();
        }

        public async Task InsertEvent(Event @event)
        {
            await _dbContext.Events.AddAsync(@event);
            await Save();
        }

        public async Task Save()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateEvent(Event @event)
        {
            _dbContext.Entry(@event).State = EntityState.Modified;
            await Save();
        }
    }
}
