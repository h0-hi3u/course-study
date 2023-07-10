using BusinessObjects.DBContext;
using BusinessObjects.EntityModels;
using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class SubjectDAO
    {
        GroupStudyContext _context = new GroupStudyContext();
        // Singleton
        public static SubjectDAO instance = null;
        public static object lockInstance = new object();
        private SubjectDAO() { }
        public static SubjectDAO Instance
        {
            get
            {
                lock (lockInstance)
                {
                    if (instance == null)
                    {
                        instance = new SubjectDAO();
                    }
                }
                return instance;
            }
        }
        //--------------------------------
        // Get list Subject
        public List<Subject> GetSubjects() => _context.Subjects.ToList();
        // Get subject by subjectID
        public Subject GetSubjectByID(string subjectID)
        {
            var subject = _context.Subjects.FirstOrDefault(s => s.SubjectId == subjectID);
            if (subject != null) {
                return subject;
            } else
            {
                return null;
            }
        }
        // Add new Subject
        public void AddSubject(Subject subject)
        {
            var check = GetSubjectByID(subject.SubjectId);
            if (check == null)
            {
                _context.Subjects.Add(subject);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Subject ID is duplicate!!!");
            }
        }
        // Update subject
        public void UpdateSubject(Subject subject)
        {
            var check = GetSubjectByID(subject.SubjectId);
            if (check != null)
            {
                _context.ChangeTracker.Clear();
                _context.Update(subject);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Subject not exists to update!!!");
            }
        }
        // Delete subject
        public void DeleteSubject (String subjecID)
        {
            var check = GetSubjectByID(subjecID);
            if (check != null)
            {
                _context.Subjects.Remove(check);
                _context.SaveChanges();
            } else
            {
                throw new Exception("Subject not exists to delete!!!");
            }
        }
    }
}
