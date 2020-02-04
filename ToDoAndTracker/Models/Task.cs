using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAndTracker.Models
{
    public enum TaskState
    {
        IsCompleted,
        IsAbandoned,
        IsBlocked,
        IsQueued,
        IsStarted
    }

    public class Task
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime ExpectedStartTime { get; set; }

        public DateTime ExpectedCompleteTime { get; set; }

        public TimeSpan ExpectedDuration { get; set; }

        public int Difficulty { get; set; }

        public TaskState State { get; set; }

        public TimeSpan RecurPeriod { get; set; }

        public ICollection<Event> Events { get; set; }
    }
}
