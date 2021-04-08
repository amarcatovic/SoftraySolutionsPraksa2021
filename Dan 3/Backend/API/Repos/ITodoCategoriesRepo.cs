using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data.Models;

namespace API.Repos
{
    public interface ITodoCategoriesRepo
    {
        Task<IEnumerable<TodoCategory>> GetTodoCategoriesAsync();

        Task AddTodoCategoryAsync(TodoCategory todoCategory);
    }
}
