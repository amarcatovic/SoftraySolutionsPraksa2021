using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data.Models;
using API.Data.Models.Dtos;
using AutoMapper;

namespace API.MappingProfiles
{
    public class TodoProfile : Profile
    {
        public TodoProfile()
        {
            CreateMap<TodoCreateDto, Todo>();

            CreateMap<Todo, TodoReadDto>();

            CreateMap<TodoUpdateDto, Todo>();
        }
    }
}
