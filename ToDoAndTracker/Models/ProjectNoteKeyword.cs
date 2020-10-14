using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAndTracker.Models
{
    [Authorize]
    public class ProjectNoteKeyword
    {
        // Many-to-Many
        public int ProjectNoteId { get; set; }
        public ProjectNote ProjectNote { get; set; }

        public string KeywordId { get; set; }
        public Keyword Keyword { get; set; }
    }
}
