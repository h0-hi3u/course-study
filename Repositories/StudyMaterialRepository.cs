using BusinessObjects.EntityModels;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class StudyMaterialRepository : IStudyMaterialRepository
    {
        void IStudyMaterialRepository.AddStudyMaterial(StudyMaterial studyMaterial) => StudyMaterialDAO.Instance.AddStudyMaterial(studyMaterial);

        void IStudyMaterialRepository.DeleteStudyMaterialByID(int ID) => StudyMaterialDAO.Instance.DeleteStudyMaterialByID(ID);

        List<StudyMaterial> IStudyMaterialRepository.GetStudyMaterials() => StudyMaterialDAO.Instance.GetStudyMaterials();

        IEnumerable<StudyMaterial> IStudyMaterialRepository.GetStudyMaterialsByID(int ID) => StudyMaterialDAO.Instance.GetStudyMaterialsByID(ID);

        void IStudyMaterialRepository.UpdateStudyMaterial(StudyMaterial studyMaterial) => StudyMaterialDAO.Instance.UpdateStudyMaterial(studyMaterial);
    }
}
