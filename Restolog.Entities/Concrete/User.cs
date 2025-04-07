using Restolog.Entities.Abstract;
using System.ComponentModel;

namespace Restolog.Entities.Concrete
{
    public class User : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public int UserRoleId { get; set; } 

        public string Password { get; set; } = string.Empty;
        public bool IsActive { get; set; }

        public virtual UserRole UserRole { get; set; }
    }
}
