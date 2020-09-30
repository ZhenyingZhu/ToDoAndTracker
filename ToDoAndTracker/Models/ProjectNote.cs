using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAndTracker.Models
{
    public class ProjectNote
    {
        [Key]
        public int Id { get; set; }

        // One-to-One Child.
        [Required]
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public ICollection<string> Keywords { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
