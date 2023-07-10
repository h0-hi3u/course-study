using BusinessObjects.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IProgressRepository
    {
        List<Progress> GetProgressesByUserInGroup(int userId, int groupId);
        void AddRange(int userId, List<Slot> slots);
        Progress GetProgress(int userId, int slotId);
        void Update(Progress progress);
    }
}
