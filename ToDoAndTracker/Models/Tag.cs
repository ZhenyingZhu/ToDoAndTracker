using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAndTracker.Models
{
    public class Tag
    {
        [Key]
        [StringLength(50)]
        public string Id { get; set; }

        // Many-to-Many.
        public ICollection<ProjectTag> ProjectTags { get; set; }
    }
}
