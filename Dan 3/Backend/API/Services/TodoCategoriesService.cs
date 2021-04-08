using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data.Models;
using API.Data.Models.Dtos;
using API.Repos;
using AutoMapper;

namespace API.Services
{
    public class TodoCategoriesService : ITodoCategoriesService
    {
        private readonly ITodoCategoriesRepo _repo;
        private readonly IMapper _mapper;

        public TodoCategoriesService(ITodoCategoriesRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TodoCategory>> GetTodoCategoriesAsync()
        {
            return await _repo.GetTodoCategoriesAsync();
        }

        public async Task AddTodoCategoryAsync(TodoCategoryCreateDto todoCategoryCreateDto)
        {
            var todoCategory = _mapper.Map<TodoCategory>(todoCategoryCreateDto);

            await _repo.AddTodoCategoryAsync(todoCategory);
        }
    }
}
