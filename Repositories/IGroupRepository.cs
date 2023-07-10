using BusinessObjects.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IGroupRepository
    {
        IEnumerable<Group> GetGroups();
        void Add(Group group);
        void Update(Group group);
        void Delete(int id);
        IEnumerable<Group> SortSubjectId();
        IEnumerable<Subject> GetSubjects();
        Group Find(int id);
    }
}
