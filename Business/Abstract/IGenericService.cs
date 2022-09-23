using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGenericService<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
        T GetById(int id);
        List<T> GetList();

    }
}
