using Restolog.Entities.Abstract;

namespace Restolog.Entities.Concrete
{
    public class TableEntity : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsFull { get; set; } = false;
        public bool IsReserved { get; set; } = false;
        public DateTime CreatedAt { get; set; }
        public DateTime? ClosedAt { get; set; }  
    }
}