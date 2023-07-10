using BusinessObjects.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        void AddNew(User user);
        void Update(User user);
        void Delete(int id);
        User GetUserById(int id);
    }
}
