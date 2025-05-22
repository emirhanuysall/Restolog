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
        public DateTime? LastOrderTime { get; set; }
        public int TableNumber { get; set; }
        public string Status { get; set; } = "Boş"; // Boş, Dolu, Rezerve
        public TimeSpan? OrderDuration { get; set; }
    }
}