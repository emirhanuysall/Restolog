using Restolog.Entities.Abstract;

namespace Restolog.Entities.Concrete
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        // İlişki: Bir kategori, birden fazla ürüne sahip olabilir
        public ICollection<Product>? Products { get; set; }
    }
}