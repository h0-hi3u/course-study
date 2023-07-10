using BusinessObjects.EntityModels;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserRepository : IUserRepository
    {
        public void AddNew(User user) => UserDAO.Instance.AddNew(user);

        public void Delete(int id) => UserDAO.Instance.Delete(id);

        public IEnumerable<User> GetUsers() => UserDAO.Instance.GetUsers();

        public void Update(User user) => UserDAO.Instance.Update(user);

        public User GetUserById(int id) => UserDAO.Instance.GetUser(id);
    }
}
