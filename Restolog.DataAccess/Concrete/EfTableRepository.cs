using Restolog.DataAccess.Abstract;
using Restolog.Entities.Concrete;

namespace Restolog.DataAccess.Concrete
{
    public class EfTableEntityRepository : ITableEntityRepository
    {
        private readonly RestologContext _context;

        public EfTableEntityRepository(RestologContext context)
        {
            _context = context;
        }

        public List<TableEntity> GetAll() => _context.Tables.ToList();

        public TableEntity GetById(int id) => _context.Tables.Find(id);

        public void Add(TableEntity tableEntity)
        {
            _context.Tables.Add(tableEntity);
            _context.SaveChanges();
        }

        public void Update(TableEntity tableEntity)
        {
            _context.Tables.Update(tableEntity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var tableEntity = _context.Tables.Find(id);
            if (tableEntity != null)
            {
                _context.Tables.Remove(tableEntity);
                _context.SaveChanges();
            }
        }
    }
}
