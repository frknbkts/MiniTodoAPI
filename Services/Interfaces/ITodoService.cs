using MiniTodo.Models;
using MiniTodo.Dtos;

namespace MiniTodo.Services.Interfaces
{
    public interface ITodoService
    {
        Task<List<Todo>> GetAllAsync();
        Task<TodoItem> GetByIdAsync(Guid id);
        Task<TodoItem> CreateAsync(TodoCreateDto dto);
        Task UpdateAsync(Guid id, TodoUpdateDto dto);
        Task DeleteAsync(Guid id);
    }
    
}