using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Data.Models;

namespace API.Repos
{
    public class TodoCategoriesRepo : ITodoCategoriesRepo
    {
        private readonly TodoContext _context;

        public TodoCategoriesRepo(TodoContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Returns list of todo categories
        /// </summary>
        /// <returns>List<TodoCategory> object</returns>
        public List<TodoCategory> GetTodoCategories()
        {
            return _context.TodoCategories.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="todoCategory">TodoCategory object</param>
        public void AddTodoCategory(TodoCategory todoCategory)
        {
            _context.TodoCategories.Add(todoCategory);
            _context.SaveChanges();
        }
    }
}
