namespace ToDoAndTrackerServer.Areas.ToDo.Models
{
    public class ProjectDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public ProjectDTO(Project project)
        {
            Id = project.Id;
            Name = project.Name;
        }
    }
}
