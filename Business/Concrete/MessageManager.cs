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
    public class MessageManager : IMessageService
    {
        private IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void Add(Message entity)
        {
            _messageDal.Insert(entity);
        }

        public void Update(Message entity)
        {
            _messageDal.Update(entity);
        }

        public void Delete(Message entity)
        {
            _messageDal.Delete(entity);
        }

        public Message GetById(int id)
        {
           return _messageDal.GetById(id);
        }

        public List<Message> GetList()
        {
           return _messageDal.GetListAll();
        }

        public List<Message> GetInBoxListByWriter(string p)
        {
            return _messageDal.GetListAll(x => x.Receiver==p);
        }
    }
}
