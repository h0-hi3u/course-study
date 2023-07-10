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
    public class ProgressDAO
    {
        GroupStudyContext _context = new GroupStudyContext();
        //-----------------------------------------
        // Singleton pattern
        public static ProgressDAO instance = null;
        private static object lockInstance = new object();
        public static ProgressDAO Instance
        {
            get
            {
                lock (lockInstance)
                {
                    if (instance == null)
                    {
                        instance = new ProgressDAO();
                    }
                }
                return instance;
            }
        }
        //---------------------------------------
        // Get list progress of user in a group
        public List<Progress> GetProgressesByUserInGroup(int userId, int groupId)
        {
            var list = _context.Progresses.Where(x => x.UserId == userId).Include(x => x.Slot).ToList();
            List<Progress> newList = new List<Progress>();  
            foreach (var item in list)
            {
                if (item.Slot.GroupId == groupId)
                {
                    newList.Add(item);
                }
            }

            return newList;
        }

        // Get Progress 
        public Progress GetProgress(int userId, int slotId) 
            => _context.Progresses.SingleOrDefault(x => x.SlotId == slotId && x.UserId == userId);

        public bool IsProgressExists(int userId, int slotId)
        {
            var progress = _context.Progresses.SingleOrDefault(x => x.SlotId == slotId && x.UserId == userId);
            if (progress == null) return false;
            else return true;

        }
        //--------------------------------------
        // Add list of progress
        public void AddRange(int userId, List<Slot> slots)
        {
            Progress progress = null;
            foreach (var item in slots)
            {
                // Set first progress to true
                if (item == slots[0])
                {
                    progress = new Progress
                    {
                        UserId = userId,
                        SlotId = item.SlotId,
                        Status = true,
                    };
                }
                else
                {
                    progress = new Progress
                    {
                        UserId = userId,
                        SlotId = item.SlotId,
                        Status = false,
                    };
                }

                if (!IsProgressExists(progress.UserId, progress.SlotId))
                {
                    _context.Progresses.Add(progress);
                    _context.SaveChanges();
                }
                else
                {
                    throw new Exception("Progress already exists.");
                }
            }
        }

        // Update 
        public void Update(Progress progress)
        {
            var prog = GetProgress(progress.UserId, progress.SlotId);
            if (prog != null)
            {
                _context.ChangeTracker.Clear();
                _context.Update(progress);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Progress does not exist.");
            }
        }

        //-----------------------------------------
    }
}
