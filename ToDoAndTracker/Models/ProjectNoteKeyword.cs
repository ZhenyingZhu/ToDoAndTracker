using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAndTracker.Models
{
    public class ProjectNoteKeyword
    {
        [Required]
        public string OwnerId { get; set; }

        // Many-to-Many
        public int ProjectNoteId { get; set; }
        public ProjectNote ProjectNote { get; set; }

        public string KeywordId { get; set; }
        public Keyword Keyword { get; set; }
    }
}
