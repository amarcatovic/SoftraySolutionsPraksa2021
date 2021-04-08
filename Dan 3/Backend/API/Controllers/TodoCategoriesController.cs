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
        public async Task<IActionResult> GetTodoCategoriesAsync()
        {
            var result = await _service.GetTodoCategoriesAsync();

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddTodoAsync([FromBody] TodoCategoryCreateDto todoCategoryCreateDto)
        {
            await _service.AddTodoCategoryAsync(todoCategoryCreateDto);

            return StatusCode(201);
        }
    }
}
