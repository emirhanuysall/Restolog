using Restolog.DataAccess.Abstract;
using Restolog.Entities.Concrete;

namespace Restolog.DataAccess.Concrete
{
    public class EfOrderRepository : IOrderRepository
    {
        private readonly RestologContext _context;

        public EfOrderRepository(RestologContext context)
        {
            _context = context;
        }

        public List<Order> GetAll() => _context.Orders.ToList();

        public Order GetById(int id) => _context.Orders.Find(id);

        // Yeni metot: Aktif siparişi al
        public Order GetActiveOrderByTableId(Guid tableId)
        {
            return _context.Orders.FirstOrDefault(o => o.TableId == tableId && !o.IsPaid);
        }

        public void Add(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public void Update(Order order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var order = _context.Orders.Find(id);
            if (order != null)
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
        }
    }

}
