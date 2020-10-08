using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAndTracker.Models
{
    public class ProjectNote
    {
        public int Id { get; set; }

        // One-to-One Child.
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        // Many-to-Many.
        public ICollection<ProjectNoteKeyword> ProjectNoteKeywords { get; set; }

        [Required]
        [DataType(DataType.Url),Display(Name = "Note Link")]
        public string Content { get; set; }
    }
}
