using Restolog.DataAccess.Abstract;
using Restolog.Entities.Concrete;

namespace Restolog.DataAccess.Concrete
{
    public class EfPaymentDetailRepository : IPaymentDetailRepository
    {
        private readonly RestologContext _context;

        public EfPaymentDetailRepository(RestologContext context)
        {
            _context = context;
        }

        public List<PaymentDetail> GetAll() => _context.PaymentDetails.ToList();

        public PaymentDetail GetById(int id) => _context.PaymentDetails.Find(id);

        public void Add(PaymentDetail paymentDetail)
        {
            _context.PaymentDetails.Add(paymentDetail);
            _context.SaveChanges();
        }

        public void Update(PaymentDetail paymentDetail)
        {
            _context.PaymentDetails.Update(paymentDetail);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var paymentDetail = _context.PaymentDetails.Find(id);
            if (paymentDetail != null)
            {
                _context.PaymentDetails.Remove(paymentDetail);
                _context.SaveChanges();
            }
        }
    }
}
