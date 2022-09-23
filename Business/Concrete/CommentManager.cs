using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
    public class CommentManager : ICommentService
    {
        private ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public List<Comment> GetList(int id)
        {
           return _commentDal.GetListAll(x => x.BlogId == id);
        }

        public void Add(Comment entity)
        {
            _commentDal.Insert(entity);
        }

        public void Update(Comment entity)
        {
            _commentDal.Update(entity);
        }

        public void Delete(Comment entity)
        {
            _commentDal.Delete(entity);
        }

        public Comment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetList()
        {
            return _commentDal.GetListAll();
        }
    }
}
