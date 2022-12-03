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
    public class TasksController : Controller
    {
        private readonly TodoRepository _repo;
        private readonly ILogger<TasksController> _logger;

        public TasksController(TodoRepository repo, ILogger<TasksController> logger)
        {
            _repo = repo;
            _logger = logger;
        }

        // GET: ToDo/Tasks
        public async Task<IActionResult> Index()
        {
              return View(await _repo.GetTodoTasksAsync());
        }

        // GET: ToDo/Tasks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskDTO = await _repo.GetTodoTaskByIdAsync(id.Value);
            if (taskDTO == null)
            {
                return NotFound();
            }

            return View(taskDTO);
        }

        // GET: ToDo/Tasks/Create
        public IActionResult Create()
        {
            return View();
        }

        // GET: ToDo/Tasks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskDTO = await _repo.GetTodoTaskByIdAsync(id.Value);
            if (taskDTO == null)
            {
                return NotFound();
            }

            return View(taskDTO);
        }

        // POST: ToDo/Tasks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,State")] TodoTaskDTO taskDTO)
        {
            if (id != taskDTO.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _repo.UpdateTodoTaskAsync(taskDTO);
                }
                catch (ObjectNotFoundException)
                {
                    return NotFound();
                }

                return RedirectToAction(nameof(Index));
            }

            return View(taskDTO);
        }

        // GET: ToDo/Tasks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskDTO = await _repo.GetTodoTaskByIdAsync(id.Value);
            if (taskDTO == null)
            {
                return NotFound();
            }

            return View(taskDTO);
        }

        // POST: ToDo/Tasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // TODO: handle it in repo.
            // if (_context.Project == null) return Problem("Entity set 'ApplicationDbContext.Project'  is null.");
            var taskDTO = await _repo.GetTodoTaskByIdAsync(id);
            if (taskDTO != null)
            {
                await _repo.DeleteTodoTaskAsync(id);
            }

            return RedirectToAction(nameof(Index), "Projects");
        }
    }
}
