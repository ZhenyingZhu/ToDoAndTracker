using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.Entity.Core;
using System.Security.Claims;
using ToDoAndTrackerServer.Data;

namespace ToDoAndTrackerServer.Areas.ToDo.Models
{
    public class TodoRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<ApplicationDbContext> _logger;
        private string _userId;

        public TodoRepository(ApplicationDbContext context, UserManager<IdentityUser> userManager, ILogger<ApplicationDbContext> logger)
        {
            _context = context;
            _userManager = userManager;
            _logger = logger;
            _userId = GetUserIdAsync().Result;
        }

        #region Project
        public async Task<ProjectDTO> CreateProjectAsync(ProjectDTO projectDTO)
        {
            Project project = new Project()
            {
                OwnerId = _userId,
                Name = projectDTO.Name,
                CreatedDate = projectDTO.CreatedDate,
                Note = projectDTO.Note,
            };
            _context.Projects.Add(project);
            await _context.SaveChangesAsync();

            return new ProjectDTO(project);
        }

        public async Task<List<ProjectDTO>> GetProjectsAsync()
        {
            // Use the DTO to avoid getting TodoItems then Projects in a loop.
            return await GetProjectsQuery()
                .Select(p => new ProjectDTO(p))
                .ToListAsync();
        }

        public async Task<ProjectDTO?> GetProjectByIdAsync(int id)
        {
            // Cannot use FindAsync because Include(TodoItems) make the return not Project
            // var project = await _context.Projects.FindAsync(id);
            var project = await GetProjectByIdQuery(id)
                .Select(p => new ProjectDTO(p))
                .FirstOrDefaultAsync();
            return project;
        }

        public async Task UpdateProjectAsync(ProjectDTO projectDTO)
        {
            var project = await GetProjectByIdQuery(projectDTO.Id)
                .FirstOrDefaultAsync();
            if (project == null)
            {
                throw new ObjectNotFoundException($"Project {projectDTO.Id} doesn't exist");
            }

            project.Name = projectDTO.Name;

            _context.Entry(project).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DBConcurrencyException) when (!ProjectExists(project.Id))
            {
                throw new ObjectNotFoundException($"Project {project.Id} doesn't exist");
            }
        }

        public async Task DeleteProjectAsync(int id)
        {
            var project = await GetProjectByIdQuery(id)
                .FirstOrDefaultAsync();
            if (project == null)
            {
                throw new ObjectNotFoundException($"Project {id} doesn't exist");
            }

            // TODO: when there are todo items refering it, how to handle it.
            // catch exception: nted
            // Microsoft.EntityFrameworkCore.DbUpdateException: An error occurred while saving the entity changes.See the inner exception for details.
            // Microsoft.Data.SqlClient.SqlException(0x80131904): The DELETE statement conflicted with the REFERENCE constraint "FK_TodoItems_Projects_ProjectId".The conflict occurred in database "TodoApi", table "dbo.TodoItems", column 'ProjectId'.
            _context.Projects.Remove(project);
            await _context.SaveChangesAsync();
        }

        private IQueryable<Project> GetProjectsQuery()
        {
            return _context.Projects
                .Where(p => p.OwnerId == _userId)
                .Include(p => p.TodoTasks);
        }

        private IQueryable<Project> GetProjectByIdQuery(int id)
        {
            return _context.Projects
                .Where(p => p.Id == id)
                .Where(p => p.OwnerId == _userId)
                .Include(p => p.TodoTasks);
        }

        private bool ProjectExists(int id)
        {
            return _context.Projects.Any(p => p.Id == id && p.OwnerId == _userId);
        }
        #endregion

        #region TodoTask
        public async Task<TodoTaskDTO> AddTodoTaskToProjectAsync(int pid, TodoTaskDTO todoTaskDTO)
        {
            var projectDTO = await GetProjectByIdAsync(pid);
            if (projectDTO == null)
            {
                throw new ObjectNotFoundException($"Project {pid} doesn't exist");
            }

            if (todoTaskDTO.Id != 0)
            {
                _logger.LogWarning($"Creating a todoTask {todoTaskDTO.Name} with id set {todoTaskDTO.Id}");
            }

            TodoTask todoTask = new TodoTask
            {
                OwnerId = _userId,
                Name = todoTaskDTO.Name,
                ProjectId = pid,
                State = (TaskState)Enum.Parse(typeof(TaskState), todoTaskDTO.State)
            };
            _context.TodoTasks.Add(todoTask);

            try
            {
                await _context.SaveChangesAsync();
                var newTodoTaskDTO = new TodoTaskDTO(todoTask)
                {
                    ProjectName = projectDTO.Name
                };

                return newTodoTaskDTO;
            }
            catch (DBConcurrencyException) when (!ProjectExists(pid))
            {
                throw new ObjectNotFoundException($"Project {pid} doesn't exist");
            }
        }

        public async Task<List<TodoTaskDTO>> GetTodoTasksAsync()
        {
            return await GetTodoTasksQuery()
                .Select(t => new TodoTaskDTO(t))
                .ToListAsync();
        }

        public async Task<TodoTaskDTO?> GetTodoTaskByIdAsync(int id)
        {
            return await GetTodoTaskByIdQuery(id)
                .Select(t => new TodoTaskDTO(t))
                .FirstOrDefaultAsync();
        }

        public async Task<List<TodoTaskDTO>> GetTodoTasksByProjectAsync(int pid)
        {
            return await GetTodoTasksQuery()
                .Where(t => t.ProjectId == pid)
                .Select(t => new TodoTaskDTO(t))
                .ToListAsync();
        }

        public async Task UpdateTodoTaskAsync(TodoTaskDTO updatedTodoTaskDTO)
        {
            // Error handling is done here because it is called by JS so cannot handle complicate logics.
            var existingTodoTask = await GetTodoTaskByIdQuery(updatedTodoTaskDTO.Id)
                .FirstOrDefaultAsync();

            if (existingTodoTask == null)
            {
                throw new ObjectNotFoundException($"Task {updatedTodoTaskDTO.Id} doesn't exist");
            }

            // Doesn't support move it to a different project. The operation will be done by another API.
            if (updatedTodoTaskDTO.ProjectId != updatedTodoTaskDTO.ProjectId)
            {
                throw new InvalidOperationException($"Cannot update project for Task {updatedTodoTaskDTO.Id}");
            }

            existingTodoTask.Name = updatedTodoTaskDTO.Name;
            existingTodoTask.State = (TaskState)Enum.Parse(typeof(TaskState), updatedTodoTaskDTO.State);

            _context.Entry(existingTodoTask).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!TodoTaskExists(updatedTodoTaskDTO.Id))
            {
                // TodoItem get deleted concurrently.
                throw new ObjectNotFoundException($"Task {updatedTodoTaskDTO.Id} doesn't exist");
            }
        }

        public async Task ChangeTodoTaskProjectAsync(int tid, int pid)
        {
            var todoTask = await GetTodoTaskByIdQuery(tid)
                .FirstOrDefaultAsync();
            if (todoTask == null)
            {
                throw new ObjectNotFoundException($"Task {tid} doesn't exist");
            }

            if (!ProjectExists(pid))
            {
                throw new ObjectNotFoundException($"Project {pid} doesn't exist");
            }

            todoTask.ProjectId = pid;
            _context.Entry(todoTask).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DBConcurrencyException)
            {
                if (!TodoTaskExists(tid))
                {
                    throw new ObjectNotFoundException($"Task {tid} doesn't exist");
                }

                if (!ProjectExists(pid))
                {
                    throw new ObjectNotFoundException($"Project {pid} doesn't exist");
                }
            }
        }

        public async Task DeleteTodoTaskAsync(int id)
        {
            // No need to remove it from project, because the project table doesn't record the reference.
            var todoTask = await GetTodoTaskByIdQuery(id)
                .FirstOrDefaultAsync();

            if (todoTask == null)
            {
                throw new ObjectNotFoundException($"Task {id} doesn't exist");
            }

            _context.TodoTasks.Remove(todoTask);
            await _context.SaveChangesAsync();
        }

        private IQueryable<TodoTask> GetTodoTasksQuery()
        {
            return _context.TodoTasks
                .Where(t => t.OwnerId == _userId)
                .Include(t => t.Project);
        }

        private IQueryable<TodoTask> GetTodoTaskByIdQuery(int id)
        {
            return _context.TodoTasks
                .Where(t => t.Id == id)
                .Where(t => t.OwnerId == _userId)
                .Include(t => t.Project);
        }

        private bool TodoTaskExists(int id)
        {
            return _context.TodoTasks.Any(t => t.Id == id && t.OwnerId == _userId);
        }
        #endregion

        #region User
        private async Task<string> GetUserIdAsync()
        {
            // TODO: is the repo for one session? It is scoped. If so, should be able to store the user id.
            if (ClaimsPrincipal.Current != null)
            {
                IdentityUser user = await _userManager.GetUserAsync(ClaimsPrincipal.Current);

                _logger.LogInformation($"Logging in user: {user.Id}.");

                return user.Id;
            }
            else
            {
                _logger.LogInformation($"ClainsPricipal is null");
                throw new ArgumentNullException(nameof(ClaimsPrincipal), "User has not logged in.");
            }
        }
        #endregion
    }
}
