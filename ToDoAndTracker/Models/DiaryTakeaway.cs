using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAndTracker.Models
{
    public class DiaryTakeaway
    {
        // Many-to-Many link.
        public int DiaryId;
        public Diary Diary;

        public int TakeawayId;
        public Takeaway Takeaway;
    }
}
