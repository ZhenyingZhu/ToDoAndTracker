using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAndTracker.Models
{
    [Authorize]
    public class Takeaway
    {
        public int Id { get; set; }

        public string OwnerId { get; set; }

        [Required]
        [DataType(DataType.Text),StringLength(256)]
        public string Content { get; set; }

        // Many-to-Many.
        public ICollection<DiaryTakeaway> DiaryTakeaways { get; set; }
    }
}
