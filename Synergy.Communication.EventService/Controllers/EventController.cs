using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Synergy.Communication.EventService.BLL.Interfaces;
using Synergy.Communication.EventService.Models.Api;

namespace Synergy.Communication.EventService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly ILogger<EventController> _logger;

        private readonly IEventServiceBLL _eventServiceBLL;
        public EventController(ILogger<EventController> logger, IEventServiceBLL eventServiceBLL)
        {
            _logger = logger;
            _eventServiceBLL = eventServiceBLL;
        }

        [Route("ping")]
        [HttpGet]

        public IActionResult Ping()
        {
            _logger.LogInformation("Event service ping test.");
            return Ok("We have received your request. Event service is running...");
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Post(Message message)
        {
            _logger.LogInformation("Processing message");

            await _eventServiceBLL.Process(message);
            // Do async actions using the business layer

            return Ok();
        }
    }
}
