using Microsoft.AspNetCore.Mvc;

namespace ToDoAndTrackerServer.Areas.ToDo.Models
{
    [ModelMetadataType(typeof(Project))]
    public class ProjectDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public ProjectDTO()
        {
            Name = null!;
        }

        public ProjectDTO(Project project)
        {
            Id = project.Id;
            Name = project.Name;
        }
    }
}
