using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data.Models
{
    public class TodoCategory
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Todo> Todos { get; set; }
    }
}
