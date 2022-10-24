namespace ToDoAndTrackerServer.Areas.ToDo.Models
{
    public class Project
    {
        public int Id { get; set; }

        public string OwnerId { get; set; } = null!;

        public string Name { get; set; } = null!;
    }
}
