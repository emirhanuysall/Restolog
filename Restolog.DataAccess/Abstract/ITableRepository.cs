using Restolog.Entities.Concrete;

namespace Restolog.DataAccess.Abstract
{
    public interface ITableEntityRepository
    {
        List<TableEntity> GetAll();
        TableEntity GetById(Guid id);
        void Add(TableEntity tableEntity);
        void Update(TableEntity tableEntity);
        void Delete(Guid id);
    }
}
