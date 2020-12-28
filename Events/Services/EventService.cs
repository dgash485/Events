using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Events.Data;
using Events.Data.Dto;
using Events.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Events.Services
{
    public class EventService : IEventService
    {
        private readonly EventsDbContext _eventsDbContext;

        public EventService(EventsDbContext judgesDbContext)
        {
            _eventsDbContext = judgesDbContext ?? throw new ArgumentNullException(nameof(judgesDbContext));
        }

        public async Task<EventDto[]> Get(int id)
        {
            return await _eventsDbContext.Events
                .Select(e => new EventDto
                {
                    Id = e.Id,
                    Name = e.Name,
                    Place = e.Place,
                    Start = e.Start,
                    End = e.End,
                    SportId = e.SportId,
                    AdminId = e.AdminId
                })
                .ToArrayAsync();
        }

        public async Task<int> Create(EventDto obj)
        {
            Event created = AplyDtoToEntity(obj);
            _eventsDbContext.Events.Add(created);
            await _eventsDbContext.SaveChangesAsync();

            return created.Id;
        }

        public async Task<int> Update(EventDto obj)
        {
            Event toUpdate = _eventsDbContext.Events.Find(obj.Id);
            toUpdate = AplyDtoToEntity(obj);
            await _eventsDbContext.SaveChangesAsync();

            return toUpdate.Id;
        }

        public async Task Delete(int id)
        {
            Event toDelete = _eventsDbContext.Events.Find(id);
            _eventsDbContext.Remove(toDelete);
            await _eventsDbContext.SaveChangesAsync();
        }

        private Event AplyDtoToEntity(EventDto obj)
        {
            Event entity = new Event();
            entity.Name = obj.Name;
            entity.Place = obj.Place;
            entity.Start = obj.Start;
            entity.End = obj.End;
            entity.SportId = obj.SportId;

            return entity;
        }
    }
}
