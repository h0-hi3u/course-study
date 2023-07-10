using BusinessObjects.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class CommentRepository : ICommentRepository
    {
        public void AddNew(Comment comment) => CommentDAO.Instance.AddNew(comment);

        public IEnumerable<Comment> GetCommentsByGroupId(int id) => CommentDAO.Instance.GetCommentsByGroupId(id);
    }
}
