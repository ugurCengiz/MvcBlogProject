﻿using System.Linq;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic4 : ViewComponent
    {
        private Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Admins.Where(x => x.AdminId == 1).Select(y => y.Name).FirstOrDefault();
            ViewBag.v2 = context.Admins.Where(x => x.AdminId == 1).Select(y => y.ImageUrl).FirstOrDefault();
            ViewBag.v3 = context.Admins.Where(x => x.AdminId == 1).Select(y => y.ShortDescriptin).FirstOrDefault();
            
            return View();
        }
    }
}
