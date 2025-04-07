using Restolog.DataAccess.Abstract;
using Restolog.Entities.Concrete;

namespace Restolog.DataAccess.Concrete
{
    public class EfPaymentRepository : IPaymentRepository
    {
        private readonly RestologContext _context;

        public EfPaymentRepository(RestologContext context)
        {
            _context = context;
        }

        public List<Payment> GetAll() => _context.Payments.ToList();

        public Payment GetById(int id) => _context.Payments.Find(id);

        public void Add(Payment payment)
        {
            _context.Payments.Add(payment);
            _context.SaveChanges();
        }

        public void Update(Payment payment)
        {
            _context.Payments.Update(payment);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var payment = _context.Payments.Find(id);
            if (payment != null)
            {
                _context.Payments.Remove(payment);
                _context.SaveChanges();
            }
        }
    }
}
