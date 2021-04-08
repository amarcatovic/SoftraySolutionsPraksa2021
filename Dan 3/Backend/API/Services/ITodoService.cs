using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data.Models;
using API.Data.Models.Dtos;

namespace API.Services
{
    public interface ITodoService
    {
        Task<IEnumerable<Todo>> GetTodosAsync();

        Task AddTodoAsync(TodoCreateDto todoCreateDto);

        Task<TodoReadDto> GetTodoByIdAsync(int id);

        Task<bool> UpdateTodoByIdAsync(int id, TodoUpdateDto todoUpdateDto);
    }
}
