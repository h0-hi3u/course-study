using BusinessObjects.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ISlotRepository
    {
        IEnumerable<Slot> GetSlots();
        void Add(Slot slot);
        void Update(Slot slot);
        void Delete(int id);
        IEnumerable<Slot> GetSlotsByGroupId(int groupId);
    }
}
