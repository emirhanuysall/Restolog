using Restolog.Entities.Concrete;

namespace Restolog.DataAccess.Abstract
{
    public interface IPaymentRepository
    {
        List<Payment> GetAll();
        Payment GetById(int id);
        void Add(Payment payment);
        void Update(Payment payment);
        void Delete(int id);
    }
}
