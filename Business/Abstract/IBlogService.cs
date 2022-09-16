using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IBlogService
	{
        void BlogAdd(Blog blog);
        void BlogUpdate(Blog blog);
        void BlogDelete(Blog blog);


        Blog GetById(int id);
        List<Blog> GetList();

        List<Blog> GetBlogListWithCategory();

        List<Blog> GetBlogListByWriter(int id);


    }
}
