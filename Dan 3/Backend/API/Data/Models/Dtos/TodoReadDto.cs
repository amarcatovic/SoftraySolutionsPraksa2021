using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data.Models.Dtos
{
    public class TodoReadDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public TodoCategoryReadDto TodoCategory { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime FinishedAt { get; set; }
    }
}
