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
    public class Message2Manager : IMessage2Service
    {
        private IMessage2Dal _message2Dal;

        public Message2Manager(IMessage2Dal message2Dal)
        {
            _message2Dal = message2Dal;
        }

        public void Add(Message2 entity)
        {
            _message2Dal.Insert(entity);
        }

        public void Update(Message2 entity)
        {
            _message2Dal.Update(entity);
        }

        public void Delete(Message2 entity)
        {
            _message2Dal.Delete(entity);
        }

        public Message2 GetById(int id)
        {
            return _message2Dal.GetById(id);
        }

        public List<Message2> GetList()
        {
            return _message2Dal.GetListAll();
        }

        public List<Message2> GetInBoxListByWriter(int id)
        {
            return _message2Dal.GetInBoxWithMessageByWriter(id);
        }

        public List<Message2> GetSendBoxListByWriter(int id)
        {
            return _message2Dal.GetSendBoxWithMessageByWriter(id);
        }
    }
}
