using Microsoft.AspNetCore.Identity;
using ToDoAndTrackerServer.Data;

namespace ToDoAndTrackerServer.Areas.ToDo.Models
{
    public class TodoRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<ApplicationDbContext> _logger;

        public TodoRepository(ApplicationDbContext context, UserManager<IdentityUser> userManager, ILogger<ApplicationDbContext> logger)
        {
            _context = context;
            _userManager = userManager;
            _logger = logger;
        }
    }
}
