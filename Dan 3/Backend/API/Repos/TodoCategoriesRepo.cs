using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Data.Models;
using Microsoft.EntityFrameworkCore;

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
        public async Task<IEnumerable<TodoCategory>> GetTodoCategoriesAsync()
        {
            return await _context.TodoCategories.ToListAsync();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="todoCategory">TodoCategory object</param>
        public async Task AddTodoCategoryAsync(TodoCategory todoCategory)
        {
            await _context.TodoCategories.AddAsync(todoCategory);
            await _context.SaveChangesAsync();
        }
    }
}
