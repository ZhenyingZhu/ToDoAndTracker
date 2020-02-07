using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAndTracker.Models
{
    public class Takeaway
    {
        public int Id { get; set; }

        public DateTime NextReminderDate { get; set; }

        public string Content { get; set; }
    }
}
