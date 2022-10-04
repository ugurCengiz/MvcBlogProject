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
    public class AdminManager : IAdminService
    {
        private IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public void Add(Admin entity)
        {
           _adminDal.Insert(entity);
        }

        public void Update(Admin entity)
        {
            _adminDal.Update(entity);
        }

        public void Delete(Admin entity)
        {
            _adminDal.Delete(entity);
        }

        public Admin GetById(int id)
        {
          return  _adminDal.GetById(id);
        }

        public List<Admin> GetList()
        {
            return _adminDal.GetListAll();
        }
    }
}
