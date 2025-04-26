using MiniTodoAPI.Common;

namespace MiniTodoAPI.Entities
{
    //TodoItem entity'si BaseEntity'den miras alır.
    public class TodoItem : BaseEntity
    {
        public string Title { get; set; }
        public bool IsCompleted { get; set; }

        // Constructor: nesne oluşturulurken başlığı zorunlu kılmak istiyoruz
        public TodoItem(string title)
        {
            Title = title;
            IsCompleted = false; // Yeni eklenen görevler varsayılan olarak tamamlanmamış olur
        }
        // Parametresiz constructor: EF Core gibi araçlar için opsiyonel bırakıyoruz (gerekirse)
        public TodoItem() {}
    }
}
