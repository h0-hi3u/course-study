using BusinessObjects.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IStudyMaterialRepository
    {
        List<StudyMaterial> GetStudyMaterials();
        IEnumerable<StudyMaterial> GetStudyMaterialsByID(int ID);
        void AddStudyMaterial(StudyMaterial studyMaterial);
        void UpdateStudyMaterial(StudyMaterial studyMaterial);
        void DeleteStudyMaterialByID(int ID);
    }
}
