using Restolog.Entities.Abstract;

namespace Restolog.Entities.Concrete
{
    public class PaymentDetail : IEntity
    {
        public Guid Id { get; set; }
        public Guid PaymentId { get; set; }
        public Payment? Payment { get; set; }
        public int OrderDetailId { get; set; }
        public OrderDetail? OrderDetail { get; set; } 
        public decimal AmountPaid { get; set; }
    }
}