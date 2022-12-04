using System.ComponentModel.DataAnnotations;

namespace ToDoAndTrackerServer.Areas.ToDo.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required]
        public string OwnerId { get; set; } = null!;

        [Required]
        public string Name { get; set; } = null!;

        [DataType(DataType.Date), Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public string? Note { get; set; }

        public ICollection<TodoTask> TodoTasks { get; set; } = null!;
    }
}
