﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAndTracker.Models
{
    public enum ProjectType
    {
        Work,
        Household,
        SelfImprove,
        Health,
        Leisure
    }

    public enum ProjectPriority
    {
        High,
        Medium,
        Low,
        None
    }

    public class Project
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public ProjectType Type { get; set; }

        // Many-to-Many relationship.
        public ICollection<Tag> Tags { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

        public DateTime DeadlineDate { get; set; }

        // One-to-One relationship.
        [Required]
        public ProjectNote ProjectNote { get; set; }

        // One-to-Many relationship.
        public ICollection<Task> Tasks { get; set; }

        [Required]
        public ProjectPriority Priority { get; set; }

        [Required]
        public bool IsCompleted { get; set; }
    }
}
