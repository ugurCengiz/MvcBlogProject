using System.Linq;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
    public class DashboardController : Controller
    {
        private BlogManager blogManager = new BlogManager(new EfBlogRepository());

        [AllowAnonymous]
        public IActionResult Index()
        {
            Context context = new Context();
            ViewBag.value1 = context.Blogs.Count().ToString();
            ViewBag.value2 = context.Blogs.Where(x => x.WriterId == 1).Count();
            ViewBag.value3 = context.Categories.Count();
            return View();
        }


    }
}
