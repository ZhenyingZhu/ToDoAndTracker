using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAndTracker.Models
{
    public class ProjectTag
    {
        // Many-to-Many link.
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public string TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
