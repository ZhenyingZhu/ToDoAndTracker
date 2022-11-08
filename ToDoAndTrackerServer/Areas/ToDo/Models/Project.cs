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

        public ICollection<TodoTask> TodoTasks { get; set; } = null!;
    }
}
