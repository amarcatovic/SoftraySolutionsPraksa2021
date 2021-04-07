using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data.Models;

namespace API.Repos
{
    public interface ITodoRepo
    {
        List<Todo> GetTodos();

        void AddTodo(Todo todo);
    }
}
