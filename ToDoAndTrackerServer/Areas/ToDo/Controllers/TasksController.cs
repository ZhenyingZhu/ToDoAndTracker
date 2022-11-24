using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ToDoAndTrackerServer.Areas.ToDo.Models;
using ToDoAndTrackerServer.Data;

namespace ToDoAndTrackerServer.Areas.ToDo.Controllers
{
    [Area("ToDo")]
    public class TasksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TasksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ToDo/Tasks
        public async Task<IActionResult> Index()
        {
              return View(await _context.TodoTaskDTO.ToListAsync());
        }

        // GET: ToDo/Tasks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TodoTaskDTO == null)
            {
                return NotFound();
            }

            var todoTaskDTO = await _context.TodoTaskDTO
                .FirstOrDefaultAsync(m => m.Id == id);
            if (todoTaskDTO == null)
            {
                return NotFound();
            }

            return View(todoTaskDTO);
        }

        // GET: ToDo/Tasks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ToDo/Tasks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,ProjectId,ProjectName,State")] TodoTaskDTO todoTaskDTO)
        {
            if (ModelState.IsValid)
            {
                _context.Add(todoTaskDTO);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(todoTaskDTO);
        }

        // GET: ToDo/Tasks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TodoTaskDTO == null)
            {
                return NotFound();
            }

            var todoTaskDTO = await _context.TodoTaskDTO.FindAsync(id);
            if (todoTaskDTO == null)
            {
                return NotFound();
            }
            return View(todoTaskDTO);
        }

        // POST: ToDo/Tasks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,ProjectId,ProjectName,State")] TodoTaskDTO todoTaskDTO)
        {
            if (id != todoTaskDTO.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(todoTaskDTO);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TodoTaskDTOExists(todoTaskDTO.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(todoTaskDTO);
        }

        // GET: ToDo/Tasks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TodoTaskDTO == null)
            {
                return NotFound();
            }

            var todoTaskDTO = await _context.TodoTaskDTO
                .FirstOrDefaultAsync(m => m.Id == id);
            if (todoTaskDTO == null)
            {
                return NotFound();
            }

            return View(todoTaskDTO);
        }

        // POST: ToDo/Tasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TodoTaskDTO == null)
            {
                return Problem("Entity set 'ApplicationDbContext.TodoTaskDTO'  is null.");
            }
            var todoTaskDTO = await _context.TodoTaskDTO.FindAsync(id);
            if (todoTaskDTO != null)
            {
                _context.TodoTaskDTO.Remove(todoTaskDTO);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TodoTaskDTOExists(int id)
        {
          return _context.TodoTaskDTO.Any(e => e.Id == id);
        }
    }
}
