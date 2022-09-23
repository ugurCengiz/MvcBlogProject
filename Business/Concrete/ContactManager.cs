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
    public class ContactManager : IContactService
    {
        private IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }


        public void Add(Contact entity)
        {
            _contactDal.Insert(entity);
        }

        public void Update(Contact entity)
        {
            throw new NotImplementedException();
        }
        public void Delete(Contact entity)
        {
            throw new NotImplementedException();
        }
        public Contact GetById(int id)
        {
            throw new NotImplementedException();
        }
        public List<Contact> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
