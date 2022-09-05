using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
         
        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);

        }
    }
}
