using System;
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

        public string Name { get; set; }

        public ProjectType Type { get; set; }

        public ICollection<Tag> Tags { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime DeadlineDate { get; set; }

        public ProjectNote ProjectNote { get; set; }

        public ICollection<Task> Tasks { get; set; }

        public ProjectPriority Priority { get; set; }

        public bool IsCompleted { get; set; }
    }
}
