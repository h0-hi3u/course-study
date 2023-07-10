using BusinessObjects.EntityModels;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class GroupRepository : IGroupRepository
    {
        public void Add(Group group) => GroupDAO.Instance.Add(group);

        public void Delete(int id) => GroupDAO.Instance.Delete(id);

        public void Update(Group group) => GroupDAO.Instance.Update(group);

        public IEnumerable<Group> GetGroups() => GroupDAO.Instance.GetGroups();

        public IEnumerable<Group> SortSubjectId() => GroupDAO.Instance.SortSubjectId();

        public IEnumerable<Subject> GetSubjects() => SubjectDAO.Instance.GetSubjects();
         public Group Find(int id) => GroupDAO.Instance.Find(id);
    }
}
