using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAndTracker.Models
{
    public class ProjectTag
    {
        [Required]
        public string OwnerId { get; set; }

        // Many-to-Many link.
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        [Required]
        public string TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
