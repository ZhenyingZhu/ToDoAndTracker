using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoAndTrackerServer.Areas.ToDo.Models
{
    [ModelMetadataType(typeof(TodoTask))]
    public class TodoTaskDTO
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int ProjectId { get; set; }

        public string ProjectName { get; set; } = null!;

        public TaskState State { get; set; }

        public TodoTaskDTO()
        {
        }

        public TodoTaskDTO(TodoTask task)
        {
            this.Id = task.Id;
            this.Name = task.Name;
            this.ProjectId = task.ProjectId;
            this.ProjectName = task.Project.Name;
            this.State = task.State;
        }
    }
}
