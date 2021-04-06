using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data.Models;

namespace API.Repos
{
    public class TodoCategoriesRepo : ITodoCategoriesRepo
    {
        /// <summary>
        /// Returns list of todo categories
        /// </summary>
        /// <returns>List<TodoCategory> object</returns>
        public List<TodoCategory> GetTodoCategories()
        {
            List<TodoCategory> result = new List<TodoCategory>();
            result.Add(new TodoCategory()
            {
                Id = 1,
                Name = "First"
            });
            result.Add(new TodoCategory()
            {
                Id = 2,
                Name = "Second"
            });
            result.Add(new TodoCategory()
            {
                Id = 3,
                Name = "Third"
            });

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="todoCategory">TodoCategory object</param>
        public void AddTodoCategory(TodoCategory todoCategory)
        {
            Console.WriteLine("TodoCategory has been added!");
        }
    }
}
