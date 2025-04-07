using Restolog.Entities.Abstract;

namespace Restolog.Entities.Concrete
{
    public class Payment : IEntity
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Order? Order { get; set; } 
        public decimal AmountPaid { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
        public DateTime PaidAt { get; set; }
    }
}