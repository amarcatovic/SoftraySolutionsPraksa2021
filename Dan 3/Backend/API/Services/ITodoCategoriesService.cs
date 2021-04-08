using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data.Models;
using API.Data.Models.Dtos;

namespace API.Services
{
    public interface ITodoCategoriesService
    {
        Task<IEnumerable<TodoCategory>> GetTodoCategoriesAsync();

        Task AddTodoCategoryAsync(TodoCategoryCreateDto todoCategoryCreateDto);
    }
}
