using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data.Models;

namespace API.Services
{
    public interface ITodoService
    {
        List<Todo> GetTodos();

        void AddTodo(Todo todo);
    }
}
