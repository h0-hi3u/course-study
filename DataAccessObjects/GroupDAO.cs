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
    public class GroupDAO
    {
        GroupStudyContext _context = new GroupStudyContext();
        public static GroupDAO instance = null;
        private static object lockInstance = new object();

        public static GroupDAO Instance
        {
            get
            {
                lock (lockInstance)
                {
                    if (instance == null)
                    {
                        instance = new GroupDAO();
                    }
                }
                return instance;
            }
        }
        //GetGroups
        public IEnumerable<Group> GetGroups() => _context.Groups.ToList();

        //Find
        public Group Find(int id) => _context.Groups.SingleOrDefault(x => x.GroupId == id);

        //AddNew
        public void Add(Group currentGroup)
        {
            if(currentGroup == null)
            {
                throw new ArgumentNullException(nameof(currentGroup));
            }

            if(Find(currentGroup.GroupId) == null)
            {
                _context.Groups.Add(currentGroup);
                _context.SaveChanges();
            }
        }
        
        //Update
        public void Update(Group currentGroup)
        {
            if(currentGroup == null)
            {
                throw new ArgumentNullException(nameof(currentGroup));
            }

            try
            {
                if(Find(currentGroup.GroupId) != null)
                {
                    _context.ChangeTracker.Clear();
                    _context.Groups.Update(currentGroup);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Group does not exist!");
            }
        }

        //Delete
        public void Delete(int Id)
        {
            try
            {
                Group group = Find(Id);
                if(group != null)
                {
                    _context.Groups.Remove(group);
                    _context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Group does not exist!");
            }
        }

        public IEnumerable<Group> SortSubjectId()
        {
            var list = _context.Groups.OrderByDescending(_ => _.Size);
            return list;
        }
        
        // Get group by user
        /*public IEnumerable<Group> GetGroupByUser(int userId)
        {
            var groups = from g in GetGroups()

            return group;
        }*/
    }
}
