using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICommentService
    {
        void CommentAdd(Comment comment);
        //void CommentUpdate(Comment comment);
        //void CommentDelete(Comment comment);
        //Comment GetById(int id);
        List<Comment> GetList(int id);
    }
}
