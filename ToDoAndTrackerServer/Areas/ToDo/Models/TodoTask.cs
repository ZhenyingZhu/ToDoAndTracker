using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoAndTrackerServer.Areas.ToDo.Models
{
    public enum TaskState
    {
        Backlog,
        InProgress,
        Blocked,
        Done,
        Abandoned,
    }

    public class TodoTask
    {
        public int Id { get; set; }

        [Required]
        public string OwnerId { get; set; } = null!;

        public string Name { get; set; } = null!;

        public int ProjectId { get; set; }

        [ForeignKey("ProjectId")]
        public Project Project { get; set; } = null!;

        public TaskState State { get; set; }
    }
}
