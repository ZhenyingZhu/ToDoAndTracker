using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAndTracker.Models
{
    public class Diary
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        public string Content { get; set; }

        // One-to-Many Parent.
        public ICollection<Event> Events { get; set; }

        // Many-to-Many.
        public ICollection<DiaryTakeaway> DiaryTakeaways { get; set; }
    }
}
