using Restolog.Entities.Concrete;

namespace Restolog.DataAccess.Abstract
{
    public interface IPaymentDetailRepository
    {
        List<PaymentDetail> GetAll();
        PaymentDetail GetById(int id);
        void Add(PaymentDetail paymentDetail);
        void Update(PaymentDetail paymentDetail);
        void Delete(int id);
    }
}
