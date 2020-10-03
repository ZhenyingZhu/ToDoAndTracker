using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAndTracker.Models
{
    public class Takeaway
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(256)]
        public string Content { get; set; }

        // Many-to-Many.
        public ICollection<DiaryTakeaway> DiaryTakeaways { get; set; }
    }
}
