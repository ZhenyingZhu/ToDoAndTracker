using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAndTracker.Models
{
    [Authorize]
    public class DiaryTakeaway
    {
        public string OwnerId { get; set; }

        // Many-to-Many link.
        public int DiaryId { get; set; }
        public Diary Diary { get; set; }

        public int TakeawayId { get; set; }
        public Takeaway Takeaway { get; set; }
    }
}
