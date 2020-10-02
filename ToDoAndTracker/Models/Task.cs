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

    public enum TaskDifficulty
    {
        Easy,
        Normal,
        Hard
    }

    public class Task
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        // One-to-Many Child.
        [Required]
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        // If not set, appear in the end of the list.
        public int StepNumber { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ExpectedStartTime { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ExpectedCompleteTime { get; set; }

        [DataType(DataType.Duration)]
        public TimeSpan ExpectedDuration { get; set; }

        [Required]
        public TaskState State { get; set; }

        // This is a string which follows an interal format.
        // Evaludate when this task completes, and create the next task with the correct ExpectedStartTime.
        // If not set, not recur.
        public string RecurRule { get; set; }

        // One-to-Many Parent.
        public ICollection<Event> Events { get; set; }

        public TaskDifficulty Difficulty { get; set; }
    }
}
