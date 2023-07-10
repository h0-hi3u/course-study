using BusinessObjects.EntityModels;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class SlotRepository : ISlotRepository
    {
        public void Add(Slot slot) => SlotDAO.Instance.Add(slot);

        public void Delete(int id) => SlotDAO.Instance.Delete(id);

        public IEnumerable<Slot> GetSlots() => SlotDAO.Instance.GetSlots();

        public void Update(Slot slot) => SlotDAO.Instance.Update(slot);

        public IEnumerable<Slot> GetSlotsByGroupId(int id) => SlotDAO.Instance.GetSlotsByGroupId(id);
    }
}
