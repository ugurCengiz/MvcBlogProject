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
        
        public IActionResult Index()
        {
            Context context = new Context();
            var userName = User.Identity.Name;
            var userMail = context.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = context.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterId).FirstOrDefault();

            ViewBag.value1 = context.Blogs.Count().ToString();
            ViewBag.value2 = context.Blogs.Where(x => x.WriterId == writerId).Count();
            ViewBag.value3 = context.Categories.Count();
            return View();
        }


    }
}
