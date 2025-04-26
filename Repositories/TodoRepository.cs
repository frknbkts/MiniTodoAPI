using MiniTodoAPI.Entities;
using MiniTodoAPI.Repositories.Interfaces;

namespace MiniTodoAPI.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        // 1. TodoItem'ları tutacak geçici bir liste oluşturuyoruz.
        private readonly List<TodoItem> _todos = new List<TodoItem>();
        // 2. Tüm Todo'ları getir
        public async Task<List<TodoItem>> GetAllAsync()
        {
            return await Task.FromResult(_todos);
        }
        // 3. ID'ye göre Todo bul
        public async Task<TodoItem> GetByIdAsync(Guid id)
        {
            var todo = _todos.FirstOrDefault(t => t.Id == id);
            return await Task.FromResult(todo);
        }
        // 4. Yeni Todo ekle
        public async Task AddAsync(TodoItem todo)
        {
            _todos.Add(todo);
            await Task.CompletedTask;
        }
        // 5. Todo güncelle
        public async Task UpdateAsync(TodoItem todo)
        {
            var existingTodo = _todos.FirstOrDefault(t => t.Id == todo.Id);
            if (existingTodo != null)
            {
                existingTodo.Title = todo.Title;
                existingTodo.IsCompleted = todo.IsCompleted;
            }
            await Task.CompletedTask;
        }
        // 6. Todo sil
        public async Task DeleteAsync(Guid id)
        {
            var todo = _todos.FirstOrDefault(t => t.Id == id);
            if (todo != null)
            {
                _todos.Remove(todo);
            }
            await Task.CompletedTask;
        }
    }
}