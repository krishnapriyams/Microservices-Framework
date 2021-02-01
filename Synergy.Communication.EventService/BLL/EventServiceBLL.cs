using Synergy.Communication.EventService.BLL.Interfaces;
using Synergy.Communication.EventService.Models.Api;
using Synergy.Communication.EventService.Repository.Interfaces;
using System;
using System.Threading.Tasks;

namespace Synergy.Communication.EventService.BLL
{
    public class EventServiceBLL : IEventServiceBLL
    {
        private readonly IEventRepository _eventRepository;
        public EventServiceBLL(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }
        public async Task Process(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
