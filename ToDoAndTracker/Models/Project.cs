using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

    [Authorize]
    public class Project
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Text),StringLength(256)]
        public string Name { get; set; }

        public ProjectType Type { get; set; }

        // Many-to-Many.
        public ICollection<ProjectTag> ProjectTags { get; set; }

        [DataType(DataType.Date),Display(Name = "Create Date")]
        public DateTime CreateDate { get; set; }

        [DataType(DataType.Date),Display(Name = "Deadline Date")]
        public DateTime DeadlineDate { get; set; }

        // One-to-One Parent.
        [Required]
        public ProjectNote Note { get; set; }

        // One-to-Many Parent.
        public ICollection<Task> Tasks { get; set; }

        public ProjectPriority Priority { get; set; }

        public bool IsCompleted { get; set; }
    }
}
