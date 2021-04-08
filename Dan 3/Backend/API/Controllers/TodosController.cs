using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data.Models;
using API.Data.Models.Dtos;
using API.Services;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoService _service;

        public TodosController(ITodoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetTodosAsync()
        {
            var result = await _service.GetTodosAsync();

            return Ok(result);
        }

        //localhost:5001/api/todos/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTodoByIdAsync(int id)
        {
            var todo = await _service.GetTodoByIdAsync(id);
            if (todo == null)
                return NotFound();

            return Ok(todo);
        }

        [HttpPost]
        public async Task<IActionResult> AddTodo([FromBody] TodoCreateDto todoCreateDto)
        {
            await _service.AddTodoAsync(todoCreateDto);

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTodoAsync(int id, [FromBody] TodoUpdateDto todoUpdateDto)
        {
            var result = await _service.UpdateTodoByIdAsync(id, todoUpdateDto);
            if (!result)
                return BadRequest("Update failed!");

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoAsync(int id)
        {
            try
            {
                var result = await _service.DeleteTodoByIdAsync(id);
                if (!result)
                {
                    return BadRequest("Todo could not be deleted");
                }

                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
