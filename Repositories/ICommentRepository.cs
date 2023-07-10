using BusinessObjects.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public interface ICommentRepository
    {
        IEnumerable<Comment> GetCommentsByGroupId(int id);
        void AddNew(Comment comment);
    }
}
