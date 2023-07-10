using BusinessObjects.EntityModels;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class SubjectRepository : ISubjectRepository
    {
        void ISubjectRepository.AddSubject(Subject subject) => SubjectDAO.Instance.AddSubject(subject);

        void ISubjectRepository.DeleteSubject(string subjecID) => SubjectDAO.Instance.DeleteSubject(subjecID);

        Subject ISubjectRepository.GetSubjectByID(string subjectID) => SubjectDAO.Instance.GetSubjectByID(subjectID);

        List<Subject> ISubjectRepository.GetSubjects() => SubjectDAO.Instance.GetSubjects();

        void ISubjectRepository.UpdateSubject(Subject subject) => SubjectDAO.Instance.UpdateSubject(subject);
    }
}
