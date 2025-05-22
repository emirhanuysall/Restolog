using Restolog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restolog.DataAccess.Concrete
{
    public class EfUserRoleRepository
    {
        private readonly RestologContext _context;

        public EfUserRoleRepository(RestologContext context)
        {
            _context = context;
        }

        public List<UserRole> GetAll()
        {
            return _context.UserRoles.ToList();
        }
    }
}
