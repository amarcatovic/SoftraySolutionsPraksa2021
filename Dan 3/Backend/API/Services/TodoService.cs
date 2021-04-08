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
    public class TodoService : ITodoService
    {
        private readonly ITodoRepo _repo;
        private readonly IMapper _mapper;

        public TodoService(ITodoRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Todo>> GetTodosAsync()
        {
            return await _repo.GetTodosAsync();
        }

        public async Task AddTodoAsync(TodoCreateDto todoCreateDto)
        {
            var todo = _mapper.Map<Todo>(todoCreateDto);

            await _repo.AddTodoAsync(todo);
        }

        public async Task<TodoReadDto> GetTodoByIdAsync(int id)
        {
            var todoFromRepo = await _repo.GetTodoByIdAsync(id);

            if (todoFromRepo.IsDeleted)
            {
                return null;
            }

            return _mapper.Map<TodoReadDto>(todoFromRepo);
        }

        public async Task<bool> UpdateTodoByIdAsync(int id, TodoUpdateDto todoUpdateDto)
        {
            var todo = _mapper.Map<Todo>(todoUpdateDto);

            return await _repo.UpdateTodoByIdAsync(id, todo);
        }
    }
}
