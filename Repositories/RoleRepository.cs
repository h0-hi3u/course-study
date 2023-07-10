using BusinessObjects.EntityModels;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class RoleRepository : IRoleRepository
    {
        public IEnumerable<Role> GetRoles() => RoleDAO.Instance.GetRoles();
        public Role GetRole(int id) => RoleDAO.Instance.GetRole(id);
    }
}
