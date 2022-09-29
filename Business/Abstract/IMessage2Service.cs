using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IMessage2Service :IGenericService<Message2>
    {
        public List<Message2> GetInBoxListByWriter(int id);

    }
}
