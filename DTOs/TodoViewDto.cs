namespace MiniTodoAPI.DTOs
{
    public class TodoViewDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
    }
}
