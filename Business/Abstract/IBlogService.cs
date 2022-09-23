﻿using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IBlogService:IGenericService<Blog>
	{
       List<Blog> GetBlogListWithCategory();
       List<Blog> GetBlogListByWriter(int id);
    }
}
