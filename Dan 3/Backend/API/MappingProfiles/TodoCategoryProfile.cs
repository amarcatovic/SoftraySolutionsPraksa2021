using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data.Models;
using API.Data.Models.Dtos;
using AutoMapper;

namespace API.MappingProfiles
{
    public class TodoCategoryProfile : Profile
    {
        public TodoCategoryProfile()
        {
            CreateMap<TodoCategoryCreateDto, TodoCategory>();

            CreateMap<TodoCategory, TodoCategoryReadDto>();
        }
    }
}
