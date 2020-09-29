using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAndTracker.Models
{
    public class ProjectTag
    {
        // Many-to-Many link.
        public int ProjectId;
        public Project Project;

        public string TagId;
        public Tag Tag;
    }
}
