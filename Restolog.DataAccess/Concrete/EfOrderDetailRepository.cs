using Restolog.DataAccess.Abstract;
using Restolog.Entities.Concrete;

namespace Restolog.DataAccess.Concrete
{
    public class EfOrderDetailRepository : IOrderDetailRepository
    {
        private readonly RestologContext _context;

        public EfOrderDetailRepository(RestologContext context)
        {
            _context = context;
        }

        public List<OrderDetail> GetAll() => _context.OrderDetails.ToList();

        public OrderDetail GetById(int id) => _context.OrderDetails.Find(id);

        public void Add(OrderDetail orderDetail)
        {
            _context.OrderDetails.Add(orderDetail);
            _context.SaveChanges();
        }

        public void Update(OrderDetail orderDetail)
        {
            _context.OrderDetails.Update(orderDetail);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var orderDetail = _context.OrderDetails.Find(id);
            if (orderDetail != null)
            {
                _context.OrderDetails.Remove(orderDetail);
                _context.SaveChanges();
            }
        }
    }
}
