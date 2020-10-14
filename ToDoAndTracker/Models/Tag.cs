using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAndTracker.Models
{
    [Authorize]
    public class Tag
    {
        [DataType(DataType.Text),StringLength(50),Display(Name = "Tag")]
        public string Id { get; set; }

        // Many-to-Many.
        public ICollection<ProjectTag> ProjectTags { get; set; }
    }
}
