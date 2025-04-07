using Restolog.Entities.Abstract;
using System.ComponentModel;

namespace Restolog.Entities.Concrete
{
    public class UserRole : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } 
    }
}