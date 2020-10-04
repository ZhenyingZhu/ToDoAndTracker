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

    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [Required]
        public ProjectType Type { get; set; }

        // Many-to-Many.
        public ICollection<ProjectTag> ProjectTags { get; set; }

        [Required]
        [Display(Name = "Create Date")]
        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Deadline Date")]
        public DateTime DeadlineDate { get; set; }

        // One-to-One Parent.
        public ProjectNote Note { get; set; }

        // One-to-Many Parent.
        public ICollection<Task> Tasks { get; set; }

        [Required]
        public ProjectPriority Priority { get; set; }

        [Required]
        public bool IsCompleted { get; set; }
    }
}
