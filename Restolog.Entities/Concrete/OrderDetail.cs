using Restolog.Entities.Abstract;

namespace Restolog.Entities.Concrete
{
    public class OrderDetail : IEntity
    {
        public int Id { get; set; }
        public Guid OrderId { get; set; }
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public Product? Product { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Subtotal  { get; set; }
    }
}