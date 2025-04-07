using Restolog.DataAccess.Abstract;
using Restolog.Entities.Concrete;

namespace Restolog.DataAccess.Concrete
{
    public class EfProductRepository : IProductRepository
    {
        private readonly RestologContext _context;

        public EfProductRepository(RestologContext context)
        {
            _context = context;
        }

        public List<Product> GetAll() => _context.Products.ToList();

        public Product GetById(int id) => _context.Products.Find(id);

        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Update(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }
    }
}
