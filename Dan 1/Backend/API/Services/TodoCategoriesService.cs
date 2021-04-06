using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data.Models;
using API.Repos;

namespace API.Services
{
    public class TodoCategoriesService : ITodoCategoriesService
    {
        private readonly ITodoCategoriesRepo _repo;

        public TodoCategoriesService(ITodoCategoriesRepo repo)
        {
            _repo = repo;
        }

        public List<TodoCategory> GetTodoCategories()
        {
            return _repo.GetTodoCategories();
        }

        public void AddTodoCategory(TodoCategory todoCategory)
        {
            _repo.AddTodoCategory(todoCategory);
        }
    }
}
