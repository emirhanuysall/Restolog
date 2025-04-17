using Microsoft.EntityFrameworkCore;
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

        public List<Product> GetAll()
        {
            return _context.Products
                           .Include(p => p.Category) 
                           .ToList();
        }

        public Product GetById(int id)
        {
            return _context.Products
                           .Include(p => p.Category)
                           .FirstOrDefault(p => p.Id == id);
        }

        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Update(Product product)
        {
            var existingProduct = _context.Products.Include(p => p.Category).FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Description = product.Description;
                existingProduct.Price = product.Price;
                existingProduct.CategoryId = product.CategoryId; 
                _context.SaveChanges();
            }
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
