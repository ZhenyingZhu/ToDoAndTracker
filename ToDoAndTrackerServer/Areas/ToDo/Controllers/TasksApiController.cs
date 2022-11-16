using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using ToDoAndTrackerServer.Areas.ToDo.Models;
using ToDoAndTrackerServer.Data;

namespace ToDoAndTrackerServer.Areas.ToDo.Controllers
{
    [Route("api/Tasks")]
    [ApiController]
    [Authorize]
    public class TasksApiController : ControllerBase
    {
        private readonly TodoRepository _repo;
        private readonly ILogger<TasksApiController> _logger;

        public TasksApiController(TodoRepository repo, ILogger<TasksApiController> logger)
        {
            _repo = repo;
            _logger = logger;
        }

        // GET: api/Tasks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoTaskDTO>>> GetTasks()
        {
            return await _repo.GetTodoTasksAsync();
        }

        // GET: api/Tasks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TodoTaskDTO>> GetTask(int id)
        {
            var todoTaskDTO = await _repo.GetTodoTaskByIdAsync(id);

            if (todoTaskDTO == null)
            {
                return NotFound();
            }

            return todoTaskDTO;
        }

        // PUT: api/Tasks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTask(int id, TodoTaskDTO todoTaskDTO)
        {
            if (id != todoTaskDTO.Id)
            {
                return BadRequest();
            }

            try
            {
                await _repo.UpdateTodoTaskAsync(todoTaskDTO);
            }
            catch (ObjectNotFoundException ex)
            {
                return NotFound(ex);
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex);
            }

            return NoContent();
        }

        // POST: api/Projects/{project id}/Tasks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("{pid}/Tasks")]
        [Route("api/Projects")]
        public async Task<ActionResult<TodoTaskDTO>> CreateTask(int pid, TodoTaskDTO todoTaskDTO)
        {
            try
            {
                var newTodoTaskDTO = await _repo.AddTodoTaskToProjectAsync(pid, todoTaskDTO);

                return CreatedAtAction(nameof(GetTask), new { id = todoTaskDTO.Id }, newTodoTaskDTO);
            }
            catch (ObjectNotFoundException ex)
            {
                return NotFound(ex);
            }
        }

        // POST: api/Tasks/{task id}/Belongs/{project id}
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("{tid}/Belongs/{pid}")]
        public async Task<IActionResult> ChangeTodoItemProject(int tid, int pid)
        {
            try
            {
                await _repo.ChangeTodoTaskProjectAsync(tid, pid);
            }
            catch (ObjectNotFoundException)
            {
                return NotFound();
            }

            return NoContent();
        }

        // DELETE: api/Tasks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(int id)
        {
            try
            {
                await _repo.DeleteTodoTaskAsync(id);
            }
            catch (ObjectNotFoundException ex)
            {
                return NotFound(ex);
            }

            return NoContent();
        }
    }
}
