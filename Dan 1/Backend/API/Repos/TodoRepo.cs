using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data.Models;

namespace API.Repos
{
    public class TodoRepo : ITodoRepo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Todo> GetTodos()
        {
            List<Todo> result = new List<Todo>();
            result.Add(new Todo()
            {
                Id = 1,
                Title = "First",
                Description = "Test",
                TodoCategoryId = 1,
                TodoCategory = new TodoCategory()
                {
                    Id = 1,
                    Name = "First"
                },
                CreatedAt = DateTime.Now
            });

            result.Add(new Todo()
            {
                Id = 2,
                Title = "Second",
                Description = "Test",
                TodoCategoryId = 1,
                TodoCategory = new TodoCategory()
                {
                    Id = 1,
                    Name = "First"
                },
                CreatedAt = DateTime.Now
            });

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="todo"></param>
        public void AddTodo(Todo todo)
        {
            Console.WriteLine("Todo has been added!");
        }
    }
}
