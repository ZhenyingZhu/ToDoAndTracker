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
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Text),StringLength(256)]
        public string Name { get; set; }

        // One-to-Many Child.
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        // If not set, appear in the end of the list.
        [Range(1, 100)]
        public int StepNumber { get; set; }

        [DataType(DataType.DateTime),Display(Name = "Expected Start Time")]
        public DateTime ExpectedStartTime { get; set; }

        [DataType(DataType.DateTime),Display(Name = "Expected Complete Time")]
        public DateTime ExpectedCompleteTime { get; set; }

        [DataType(DataType.Duration),Display(Name = "Expected How Long to Complete")]
        public TimeSpan ExpectedDuration { get; set; }

        public TaskState State { get; set; }

        // This is a string which follows an interal format.
        // Evaludate when this task completes, and create the next task with the correct ExpectedStartTime.
        // If not set, not recur.
        // TODO: when defined how to implement it, add a regular expression.
        [DataType(DataType.Text),Display(Name = "How to Recur")]
        public string RecurRule { get; set; }

        // One-to-Many Parent.
        public ICollection<Event> Events { get; set; }

        public TaskDifficulty Difficulty { get; set; }
    }
}
