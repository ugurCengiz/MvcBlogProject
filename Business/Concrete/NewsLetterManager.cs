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
    public class NewsLetterManager : INewsLetterService
    {
        private INewsLetterDal _newsLetterDal;

        public NewsLetterManager(INewsLetterDal newsLetterDal)
        {
            _newsLetterDal = newsLetterDal;
        }


        public void Add(NewsLetter entity)
        {
            _newsLetterDal.Insert(entity);
        }

        public void Update(NewsLetter entity)
        {
            throw new NotImplementedException();
        }
        public void Delete(NewsLetter entity)
        {
            throw new NotImplementedException();
        }
        public NewsLetter GetById(int id)
        {
            throw new NotImplementedException();
        }
        public List<NewsLetter> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
