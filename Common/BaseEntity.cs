namespace MiniTodoAPI.Common
{
    //Abstract class doğrudan nesnesi oluşturulamaz, sadece miras alınır.
    public abstract class BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid(); // Her entity için benzersiz Id
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow; // Entity oluşturulma tarihi

    }
}