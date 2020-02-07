using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAndTracker.Models
{
    public class Tag
    {
        public string Name { get; set; }

        public ICollection<Tag> SubTags { get; set; }
    }
}
