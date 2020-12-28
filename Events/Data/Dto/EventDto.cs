using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events.Data.Dto
{
    public class EventDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Place { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public int? SportId { get; set; }

        public int? AdminId { get; set; }
    }
}
