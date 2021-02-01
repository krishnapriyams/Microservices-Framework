using Synergy.Communication.EventService.Models.Api;
using System.Threading.Tasks;

namespace Synergy.Communication.EventService.BLL.Interfaces
{
    public interface IEventServiceBLL
    {
        Task Process(Message message);
    }
}
