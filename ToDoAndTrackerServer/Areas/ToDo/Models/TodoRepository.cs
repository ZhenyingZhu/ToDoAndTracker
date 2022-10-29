using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
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

        private async Task<string> GetUserIdAsync()
        {
            // TODO: Migrate to the new way of dotnet core
            if (ClaimsPrincipal.Current != null)
            {
                IdentityUser user = await _userManager.GetUserAsync(ClaimsPrincipal.Current);

                _logger.LogInformation($"Logging in user: {user.Id}");

                return user.Id;
            }
            else
            {
                _logger.LogInformation($"ClainsPricipal is null");
                return "Not logged in";
            }
        }

    }
}
