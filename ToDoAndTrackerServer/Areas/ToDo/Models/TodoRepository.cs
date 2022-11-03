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
                Name = projectDTO.Name
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
                .Where(p => p.OwnerId == _userId);
            // .Include(p => p.TodoItems)
        }

        private IQueryable<Project> GetProjectByIdQuery(int id)
        {
            return _context.Projects
                .Where(p => p.Id == id)
                .Where(p => p.OwnerId == _userId);
                // .Include(p => p.TodoItems)
        }

        private bool ProjectExists(int id)
        {
            return _context.Projects.Any(p => p.Id == id && p.OwnerId == _userId);
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
