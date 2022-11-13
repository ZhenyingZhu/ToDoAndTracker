using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoAndTrackerServer.Areas.ToDo.Models;
using ToDoAndTrackerServer.Data;

namespace ToDoAndTrackerServer.Areas.ToDo.Controllers
{
    [Route("api/Tasks")]
    [ApiController]
    [Authorize]
    public class TodoTasksApiController : ControllerBase
    {
        private readonly TodoRepository _repo;
        private readonly ILogger<TodoTasksApiController> _logger;

        public TodoTasksApiController(TodoRepository repo, ILogger<TodoTasksApiController> logger)
        {
            _repo = repo;
            _logger = logger;
        }

        // GET: api/TodoTasksApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoTaskDTO>>> GetTodoTasks()
        {
            return await _repo.GetTodoTasksAsync();
        }

        // GET: api/TodoTasksApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TodoTaskDTO>> GetTodoTask(int id)
        {
            var todoTaskDTO = await _repo.GetTodoTaskByIdAsync(id);

            if (todoTaskDTO == null)
            {
                return NotFound();
            }

            return todoTaskDTO;
        }

        // PUT: api/TodoTasksApi/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodoTaskDTO(int id, TodoTaskDTO todoTaskDTO)
        {
            if (id != todoTaskDTO.Id)
            {
                return BadRequest();
            }

            _context.Entry(todoTaskDTO).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TodoTaskDTOExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TodoTasksApi
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TodoTaskDTO>> PostTodoTaskDTO(TodoTaskDTO todoTaskDTO)
        {
            _context.TodoTaskDTO.Add(todoTaskDTO);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTodoTaskDTO", new { id = todoTaskDTO.Id }, todoTaskDTO);
        }

        // DELETE: api/TodoTasksApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoTaskDTO(int id)
        {
            var todoTaskDTO = await _context.TodoTaskDTO.FindAsync(id);
            if (todoTaskDTO == null)
            {
                return NotFound();
            }

            _context.TodoTaskDTO.Remove(todoTaskDTO);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TodoTaskDTOExists(int id)
        {
            return _context.TodoTaskDTO.Any(e => e.Id == id);
        }
    }
}
