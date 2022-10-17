using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAndTracker.Models
{
    public class Keyword
    {
        [DataType(DataType.Text), StringLength(50), Display(Name = "Keyword")]
        public string Id { get; set; }

        [Required]
        public string OwnerId { get; set; }

        // Many-to-Many.
        public ICollection<ProjectNoteKeyword> ProjectNoteKeywords { get; set; }

    }
}
