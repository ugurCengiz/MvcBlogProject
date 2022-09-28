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
    public class NotificationManager:INatificationService
    {
        private INotificationDal _natificationDal;

        public NotificationManager(INotificationDal notificationDal)
        {
            _natificationDal = notificationDal;
        }

        public void Add(Natification entity)
        {
            _natificationDal.Insert(entity);
        }

        public void Update(Natification entity)
        {
            _natificationDal.Update(entity);
        }

        public void Delete(Natification entity)
        {
            _natificationDal.Delete(entity);
        }

        public Natification GetById(int id)
        {
           return _natificationDal.GetById(id);
        }

        public List<Natification> GetList()
        {
            return _natificationDal.GetListAll();
        }
    }
}
