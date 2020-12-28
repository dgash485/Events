using System.Threading.Tasks;
using Events.Data.Dto;
using Events.Data.Models;
using Events.Services;
using Microsoft.AspNetCore.Mvc;

namespace Events.Controllers
{
    [Route("Event")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly EventService _eventService;

        public EventController(EventService eventService)
        {
            _eventService = eventService;
        }

        /// <summary>
        /// Получение мероприятия по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор мероприятия.</param>
        /// <returns>Модель мероприятия.</returns>
        [HttpGet]
        [Route(nameof(Get))]
        public async Task<IActionResult> Get(int id)
        {
            var eventDto = await _eventService.Get(id);
            return Ok(new { Success = true, Event = eventDto });
        }

        /// <summary>
        /// Добавление мероприятия.
        /// </summary>
        /// <param name="judgeDto">Модель для добавления.</param>
        /// <returns>Идентификатор добавленного мероприятия.</returns>
        [HttpPost]
        [Route(nameof(Create))]
        [Produces("application/json")]
        public async Task<IActionResult> Create(EventDto eventDto)
        {
            return Ok(new { Success = true, EventId = await _eventService.Create(eventDto) });
        }

        /// <summary>
        /// Обновление мероприятия.
        /// </summary>
        /// <param name="judgeDto">Модель для обновления.</param>
        /// <returns>Идентификатор обновленной мероприятия.</returns>
        [HttpPost]
        [Route(nameof(Update))]
        [Produces("application/json")]
        public async Task<IActionResult> Update(EventDto eventDto)
        {
            await _eventService.Update(eventDto);

            return Ok(new { Success = true });
        }

        /// <summary>
        /// Удаление мероприятия.
        /// </summary>
        /// <param name="id">Модель для удаления.</param>
        /// <returns>Идентификатор обновленной мероприятия.</returns>
        [HttpPost]
        [Route(nameof(Delete))]
        [Produces("application/json")]
        public async Task<IActionResult> Delete(int id)
        {
            await _eventService.Delete(id);

            return Ok(new { Success = true });
        }
    }
}
