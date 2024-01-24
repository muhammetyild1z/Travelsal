using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class CommentManager : ICommentService
    {
        ICommentDal _CommentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _CommentDal = commentDal;
        }

        public void Tadd(Comment t)
        {
            _CommentDal.Insert(t);
        }

        public void Tdelete(Comment t)
        {
            throw new NotImplementedException();
        }

        public List<Comment> TgetList()
        {
            throw new NotImplementedException();
        }

        public List<Comment> TgetListById(int id)
        {
            return _CommentDal.GetListAllById(x=>x.destinationId==id);
        }

        public void Tupdate(Comment t)
        {
            throw new NotImplementedException();
        }
    }
}
