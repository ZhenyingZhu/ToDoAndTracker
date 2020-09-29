using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAndTracker.Models
{
    public enum EventEfficiency
    {
        High,
        Medium,
        Low
    }

    public class Event
    {
        [Key]
        public int Id { get; set; }

        // One-to-Many Child.
        public int TaskId { get; set; }
        public Task Task { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public EventEfficiency Efficiency { get; set; }


    }
}
