using Restolog.Entities.Concrete;

namespace Restolog.DataAccess.Abstract
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
        Category GetById(int id);
        void Add(Category category);
        void Update(Category category);
        void Delete(int id);
    }
}
