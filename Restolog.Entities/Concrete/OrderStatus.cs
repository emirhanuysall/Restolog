using Restolog.Entities.Abstract;
using System.ComponentModel;

namespace Restolog.Entities.Concrete
{
    public class OrderStatus : IEntity
    {
        public int Id { get; set; }
        public string StatusName { get; set; }
    }
}