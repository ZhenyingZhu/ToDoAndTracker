using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ToDoAndTrackerServer.Areas.ToDo.Models;
using ToDoAndTrackerServer.Data;

namespace ToDoAndTrackerServer.Areas.ToDo.Controllers
{
    [Area("ToDo")]
    [Authorize]
    public class ProjectsController : Controller
    {
        private readonly TodoRepository _repo;
        private readonly ILogger<ProjectsController> _logger;

        public ProjectsController(TodoRepository repo, ILogger<ProjectsController> logger)
        {
            _repo = repo;
            _logger = logger;
        }

        // GET: ToDo/Projects
        public async Task<IActionResult> Index()
        {
            return View(await _repo.GetProjectsAsync());
        }

        // GET: ToDo/Projects/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectDTO = await _repo.GetProjectByIdAsync(id.Value);
            if (projectDTO == null)
            {
                return NotFound();
            }

            return View(projectDTO);
        }

        // GET: ToDo/Projects/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ToDo/Projects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,CreatedDate,Note")] ProjectDTO projectDTO)
        {
            if (ModelState.IsValid)
            {
                await _repo.CreateProjectAsync(projectDTO);
                return RedirectToAction(nameof(Index));
            }
            return View(projectDTO);
        }

        // GET: ToDo/Projects/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectDTO = await _repo.GetProjectByIdAsync(id.Value);
            if (projectDTO == null)
            {
                return NotFound();
            }

            return View(projectDTO);
        }

        // POST: ToDo/Projects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] ProjectDTO projectDTO)
        {
            if (id != projectDTO.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _repo.UpdateProjectAsync(projectDTO);
                }
                catch (ObjectNotFoundException)
                {
                    return NotFound();
                }

                return RedirectToAction(nameof(Index));
            }

            return View(projectDTO);
        }

        // GET: ToDo/Projects/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectDTO = await _repo.GetProjectByIdAsync(id.Value);
            if (projectDTO == null)
            {
                return NotFound();
            }

            return View(projectDTO);
        }

        // POST: ToDo/Projects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // TODO: handle it in repo.
            // if (_context.Project == null) return Problem("Entity set 'ApplicationDbContext.Project'  is null.");
            var projectDTO = await _repo.GetProjectByIdAsync(id);
            if (projectDTO != null)
            {
                await _repo.DeleteProjectAsync(id);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
