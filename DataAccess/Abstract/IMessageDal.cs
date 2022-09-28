using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete;

namespace DataAccess.Abstract
{
    public interface IMessageDal : IGenericDal<Message>
    {
    }
}
