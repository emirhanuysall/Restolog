using Restolog.Entities.Concrete;

namespace Restolog.DataAccess.Abstract
{
    public interface ITableEntityRepository
    {
        List<TableEntity> GetAll();
        TableEntity GetById(int id);
        void Add(TableEntity tableEntity);
        void Update(TableEntity tableEntity);
        void Delete(int id);
    }
}
