using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAndTracker.Models
{
    public class DiaryTakeaway
    {
        [Required]
        public string OwnerId { get; set; }

        // Many-to-Many link.
        public int DiaryId { get; set; }
        public Diary Diary { get; set; }

        public int TakeawayId { get; set; }
        public Takeaway Takeaway { get; set; }
    }
}
