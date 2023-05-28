using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class CommentManager : ICommentService
    {

        ICommentDal _commentdal;

        public CommentManager(ICommentDal commentdal)
        {
            _commentdal = commentdal;
        }

        public void CommentAdd(Comment comment)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetList(int id)
        {
         return   _commentdal.GetListAll(x => x.BlogID == id);
        }

        public List<Comment> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
