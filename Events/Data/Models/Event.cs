using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Events.Data.Models
{
    [Table("events")]
    public class Event
    {
        [Column("id", TypeName = "serial")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("name", TypeName = "varchar(150)")]
        public string Name { get; set; }

        [Column("place", TypeName = "varchar(150)")]
        public string Place { get; set; }

        [Column("start", TypeName = "timestamptz")]
        public DateTime Start { get; set; }

        [Column("end", TypeName = "timestamptz")]
        public DateTime End { get; set; }

        [Column("sport_id", TypeName = "integer")]
        public int? SportId { get; set; }

        [Column("admin_id", TypeName = "integer")]
        public int? AdminId { get; set; }
    }
}
