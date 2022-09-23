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
    public class WriterManager : IWriterService
    {
        private IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }


        public void Add(Writer entity)
        {
            _writerDal.Insert(entity);
        }

        public void Update(Writer entity)
        {
            throw new NotImplementedException();
        }
        public void Delete(Writer entity)
        {
            throw new NotImplementedException();
        }
        public Writer GetById(int id)
        {
            throw new NotImplementedException();
        }
        public List<Writer> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
