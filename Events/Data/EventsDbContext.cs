using System.Diagnostics.CodeAnalysis;
using Events.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Events.Data
{
    public class EventsDbContext : DbContext
    {
        public EventsDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {

        }

        public DbSet<Event> Events { get; set; }
    }
}
