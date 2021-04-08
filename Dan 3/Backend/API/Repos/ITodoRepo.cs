using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data.Models;

namespace API.Repos
{
    public interface ITodoRepo
    {
        Task<IEnumerable<Todo>> GetTodosAsync();

        Task AddTodoAsync(Todo todo);

        Task<Todo> GetTodoByIdAsync(int id);

        Task<bool> UpdateTodoByIdAsync(int id, Todo todo);

        Task<bool> DeleteTodoByIdAsync(int id);
    }
}
