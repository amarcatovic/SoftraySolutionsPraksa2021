using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data.Models;
using API.Repos;

namespace API.Services
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepo _repo;

        public TodoService(ITodoRepo repo)
        {
            _repo = repo;
        }

        public List<Todo> GetTodos()
        {
            return _repo.GetTodos();
        }

        public void AddTodo(Todo todo)
        {
            _repo.AddTodo(todo);
        }
    }
}
