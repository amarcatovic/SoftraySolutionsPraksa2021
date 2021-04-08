using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data.Models.Dtos
{
    public class TodoCategoryCreateDto
    {
        [Required]
        public string Name { get; set; }
    }
}
