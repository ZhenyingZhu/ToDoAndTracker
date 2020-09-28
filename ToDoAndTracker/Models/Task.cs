﻿using System;
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
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        // If not set, appear in the end of the list.
        public int StepNumber { get; set; }

        public DateTime ExpectedStartTime { get; set; }

        public DateTime ExpectedCompleteTime { get; set; }

        public TimeSpan ExpectedDuration { get; set; }

        public TaskState State { get; set; }

        // If not set, not recur.
        public TimeSpan RecurPeriod { get; set; }

        // One-to-Many Parent.
        public ICollection<Event> Events { get; set; }

        public TaskDifficulty Difficulty { get; set; }
    }
}
