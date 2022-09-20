using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Repositories;
using Entity.Concrete;

namespace DataAccess.EntityFramework
{
    public class EfNewsLetterRepository : GenericRepository<NewsLetter>,INewsLetterDal
    {

    }
}
