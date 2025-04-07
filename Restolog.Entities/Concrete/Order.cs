using Restolog.Entities.Abstract;
using System.ComponentModel;

namespace Restolog.Entities.Concrete
{
    public class Order : IEntity
    {
        public Guid Id { get; set; }
        public Guid TableId { get; set; }
        public TableEntity? Table { get; set; }
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? ClosedAt { get; set; }
        public decimal TotalPrice { get; set; }
        public bool IsPaid { get; set; }

        public int OrderStatusId { get; set; }  

        public virtual OrderStatus OrderStatus { get; set; }

        public ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
