using BusinessObjects.DBContext;
using BusinessObjects.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class StudyMaterialDAO
    {
        GroupStudyContext _context = new GroupStudyContext();
        //--------------------------------
        // Singleton
        public static StudyMaterialDAO instance = null;
        public static object lockInstance = new object();
        private StudyMaterialDAO() { }
        public static StudyMaterialDAO Instance
        {
            get
            {
                lock (lockInstance)
                {
                    if (instance == null)
                    {
                        instance = new StudyMaterialDAO();
                    }
                }
                return instance;
            }
        }
        // Get all Study Material
        public List<StudyMaterial> GetStudyMaterials() => _context.StudyMaterials.ToList();
        // Get list Study Material by slot ID
        public List<StudyMaterial> GetStudyMaterialsByID(int ID)
        {
            var list = _context.StudyMaterials.Where(s => s.SlotId == ID).ToList();
            return list;
        }
        // Add Study Material
        public void AddStudyMaterial(StudyMaterial studyMaterial)
        {
            _context.StudyMaterials.Add(studyMaterial);
            _context.SaveChanges();
        }
        // Update Study Material
        public void UpdateStudyMaterial(StudyMaterial studyMaterial)
        {
            var check = _context.StudyMaterials.SingleOrDefault(s => s.StudyMaterialId == studyMaterial.SlotId);
            if (check != null)
            {
                _context.ChangeTracker.Clear();
                _context.StudyMaterials.Update(studyMaterial);
                _context.SaveChanges();
            } else
            {
                throw new Exception("Can not update Study Material");
            }
        }
        // Delete Study Material by ID
        public void DeleteStudyMaterialByID(int ID)
        {
            var check = _context.StudyMaterials.SingleOrDefault(s => s.StudyMaterialId == ID);
            if (check != null)
            {
                _context.StudyMaterials.Remove(check);
            } else
            {
                throw new Exception("Can not delete Study Material");
            }
        }
    }
}
