using BusinessObjects.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ISubjectRepository
    {
        List<Subject> GetSubjects();
        Subject GetSubjectByID(String subjectID);
        void AddSubject(Subject subject);
        void UpdateSubject(Subject subject);
        void DeleteSubject(String subjecID);
    }
}
