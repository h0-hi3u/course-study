using BusinessObjects.DBContext;
using BusinessObjects.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class RoleDAO
    {
        GroupStudyContext _context = new GroupStudyContext();
        //-----------------------------------------
        // Apply Singleton patter
        private RoleDAO() { }
        private static RoleDAO instance = null;
        private static object instanceLock = new object();
        public static RoleDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new RoleDAO();
                    }
                }

                return instance;
            }
        }

        //----------------------------------------
        // Get role list
        public List<Role> GetRoles() => _context.Roles.ToList();

        // Get role
        public Role GetRole(int id)
        {
            var role = _context.Roles.SingleOrDefault(x => x.RoleId == id);
            return role;
        }
    }
}
