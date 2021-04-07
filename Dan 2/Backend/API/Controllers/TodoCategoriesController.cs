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
    [Route("api/[controller]")] // https://localhost/api/TodoCategories
    [ApiController]
    public class TodoCategoriesController : ControllerBase
    {
        private readonly ITodoCategoriesService _service;

        public TodoCategoriesController(ITodoCategoriesService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetTodoCategories()
        {
            var result = _service.GetTodoCategories();

            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddTodo([FromBody] TodoCategory todoCategory)
        {
            _service.AddTodoCategory(todoCategory);

            return StatusCode(201);
        }
    }
}
