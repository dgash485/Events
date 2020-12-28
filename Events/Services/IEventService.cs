using System.Threading.Tasks;
using Events.Data.Dto;

namespace Events.Services
{
    public interface IEventService
    {
        Task<EventDto[]> Get(int id);

        Task<int> Create(EventDto obj);

        Task<int> Update(EventDto obj);

        Task Delete(int id);
    }
}
