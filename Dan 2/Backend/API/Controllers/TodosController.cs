using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data.Models;
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
        public IActionResult GetTodos()
        {
            var result = _service.GetTodos();

            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddTodo([FromBody] Todo todo)
        {
            _service.AddTodo(todo);

            return StatusCode(201);
        }
    }
}
