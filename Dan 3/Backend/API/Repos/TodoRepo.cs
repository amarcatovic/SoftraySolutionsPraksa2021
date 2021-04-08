using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repos
{
    public class TodoRepo : ITodoRepo
    {
        private readonly TodoContext _context;

        public TodoRepo(TodoContext context)
        {
            _context = context;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Todo>> GetTodosAsync()
        {
            return await _context.Todos
                .Include(t => t.TodoCategory)
                .ToListAsync();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="todo"></param>
        public async Task AddTodoAsync(Todo todo)
        {
            await _context.Todos.AddAsync(todo);
            await _context.SaveChangesAsync();
        }

        public async Task<Todo> GetTodoByIdAsync(int id)
        {
            var todoFromDb = await _context.Todos
                .Include(t => t.TodoCategory)
                .SingleOrDefaultAsync(t => t.Id == id);

            return todoFromDb;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="todo"></param>
        /// <returns></returns>
        public async Task<bool> UpdateTodoByIdAsync(int id, Todo todo)
        {
            var todoFromDb = await GetTodoByIdAsync(id);
            todoFromDb.Title = todo.Title;

            return await _context.SaveChangesAsync() >= 0;
        }

        public async Task<bool> DeleteTodoByIdAsync(int id)
        {
            var todoFromDb = await GetTodoByIdAsync(id);
            todoFromDb.IsDeleted = true;

            return await _context.SaveChangesAsync() >= 0;
        }
    }
}
