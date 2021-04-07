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
        public List<Todo> GetTodos()
        {
            return _context.Todos
                .Include(t => t.TodoCategory)
                .ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="todo"></param>
        public void AddTodo(Todo todo)
        {
            _context.Todos.Add(todo);
            _context.SaveChanges();
        }
    }
}
