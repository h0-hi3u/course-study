using BusinessObjects.DBContext;
using BusinessObjects.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class CommentDAO
    {
        GroupStudyContext _context = new GroupStudyContext();
        //--------------------------------------------------
        // Apply Singleton pattern
        private CommentDAO() { }
        private static CommentDAO instance = null;
        private static object instanceLock = new object();
        public static CommentDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CommentDAO();
                    }
                }

                return instance;
            }
        }
        //-------------------------------------------------
        // Get comment by groupId
        public List<Comment> GetCommentsByGroupId(int groupId) => _context.Comments.Where(x => x.GroupId == groupId).Include(x => x.User).ToList();
        public Comment GetComment(int id)
        {
            var comment = _context.Comments.SingleOrDefault(x => x.CommentId == id);
            return comment;
        }
        //-------------------------------------------------
        public void AddNew(Comment comment)
        {
            var comm = GetComment(comment.CommentId);
            
            if (comm == null)
            {
                _context.Add(comment);
                _context.SaveChanges();
            }
        }

    }
}
