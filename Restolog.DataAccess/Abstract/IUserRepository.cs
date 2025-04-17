using Restolog.Entities.Concrete;

namespace Restolog.DataAccess.Abstract
{
    public interface IUserRepository
    {
        List<User> GetAll();
        User GetById(Guid id);
        void Add(User user);
        void Update(User user);
        void Delete(Guid id);
    }
}
