using Restolog.Entities.Abstract;

namespace Restolog.Entities.Concrete
{
    public class TableEntity : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsFull { get; set; }
        public bool IsReserved { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ClosedAt { get; set; }  
    }
}