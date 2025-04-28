using MiniTodo.Models;
using MiniTodo.Dtos;
using MiniTodo.Repositories.Interfaces;
using MiniTodo.Services.Interfaces;

namespace MiniTodoAPI.Services
{
    public class TodoService : ITodoService
    {
        private readonly IRepository<Todo> _todoRepository;
        
        // Constructor: Bağımlılık enjeksiyonu yapıyoruz
        public TodoService(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }
        
        public async Task<List<TodoItem>> GetAllAsync()
        {
            return await _todoRepository.GetAllAsync();
        }

        public async Task<TodoItem> GetByIdAsync(Guid id)
        {
            return await _todoRepository.GetByIdAsync(id);
        }

        public async Task<TodoItem> CreateAsync(TodoCreateDto dto)
        {
            var todo = new TodoItem
            {
                Title = dto.Title,
                IsCompleted = false
            };

            return await _todoRepository.CreateAsync(todo);
            return todo;
        }
        
        public async Task UpdateAsync(Guid id, TodoUpdateDto dto)
        {
            var existingTodo = await _todoRepository.GetByIdAsync(id);
            if (existingTodo != null)
            {
                existingTodo.Title = dto.Title;
                existingTodo.IsCompleted = dto.IsCompleted;

                await _todoRepository.UpdateAsync(existingTodo);
            }
        }
        
        public async Task DeleteAsync(Guid id)
        {
            await _todoRepository.DeleteAsync(id);
        }
    }
}
