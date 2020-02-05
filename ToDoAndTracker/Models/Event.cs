using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAndTracker.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }

        public int TaskId { get; set; }

        public Task Task { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public bool Ongoing { get; set; }
    }
}
