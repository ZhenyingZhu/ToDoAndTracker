using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAndTracker.Models
{
    [Authorize]
    public class Diary
    {
        public int Id { get; set; }

        public string OwnerId { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }

        // One-to-Many Parent.
        public ICollection<Event> Events { get; set; }

        // Many-to-Many.
        public ICollection<DiaryTakeaway> DiaryTakeaways { get; set; }
    }
}
