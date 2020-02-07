using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAndTracker.Models
{
    public class Diary
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string Content { get; set; }
    }
}
