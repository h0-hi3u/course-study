using BusinessObjects.DBContext;
using BusinessObjects.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class SlotDAO
    {
        GroupStudyContext _context = new GroupStudyContext();
        public static SlotDAO instance = null;
        private static object lockInstance = new object();
        
        public static SlotDAO Instance
        {
            get
            {
                lock (lockInstance)
                {
                    if(instance == null)
                    {
                        instance = new SlotDAO();
                    }
                }
                return instance;
            }
        }
        //----------------------------------------------------
        // Get slots
        public List<Slot> GetSlots() => _context.Slots.ToList();

        private Slot Find(int id) => _context.Slots.FirstOrDefault(x => x.SlotId == id);
        // Get slots by groupId
        public List<Slot> GetSlotsByGroupId(int id) => _context.Slots.Where(x => x.GroupId == id).ToList();

        //----------------------------------------------------

        private Boolean isExistSlotIndex(Slot slot) 
            =>_context.Slots.FirstOrDefault(x => x.GroupId == slot.GroupId && x.SlotIndex == slot.SlotIndex) == null ? true : false;
        public void Add(Slot newSlot)
        {
            var Slot = Find(newSlot.SlotId);
            if (Slot == null)
            {
                if(isExistSlotIndex(newSlot))
                {
                    _context.Slots.Add(newSlot);
                    _context.SaveChanges();
                }
                else
                {
                    throw new Exception("Index is exist");
                }
            }
            else
            {
                throw new Exception("Slot already exist");
            }
        }

        //Update Slot
        public void Update(Slot newSlot)
        {
            var Slot = Find(newSlot.SlotId);
            if (Slot != null)
            {
                _context.ChangeTracker.Clear();
                _context.Slots.Update(newSlot);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Slot does not exist");
            }
        }

        // Delete Slot 
        public void Delete(int id)
        {
            var Slot = Find(id);
            if (Slot != null)
            {
                _context.Remove(Slot);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Slot does not exist");
            }
        }
    }
}
