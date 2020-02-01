using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAndTracker.Models
{
    public class Note
    {
        public int Id { get; set; }

        public Project Project { get; set; }
    }
}
