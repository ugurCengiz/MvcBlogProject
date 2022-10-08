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
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(AppUser entity)
        {
           _userDal.Insert(entity);
        }

        public void Update(AppUser entity)
        {
            _userDal.Update(entity);
        }

        public void Delete(AppUser entity)
        {
            _userDal.Delete(entity);
        }

        public AppUser GetById(int id)
        {
            return _userDal.GetById(id);
        }

        public List<AppUser> GetList()
        {
            return _userDal.GetListAll();
        }
    }
}
