using System.Linq;
using System.Security.Claims;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
    public class DashboardController : Controller
    {
        private BlogManager blogManager = new BlogManager(new EfBlogRepository());
        UserManager<AppUser> _userManager;

        public DashboardController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            Context context = new Context();
            var userName = User.Identity.Name;
            var userMail = context.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = context.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterId).FirstOrDefault();
            var name = context.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterName).FirstOrDefault();
            Claim userNameClaim = new Claim("userNameClaim", name, ClaimValueTypes.String, "Internal");

            var user = _userManager.FindByNameAsync(userName).Result;

            _userManager.AddClaimAsync(user, userNameClaim);

            ViewBag.value1 = context.Blogs.Count().ToString();
            ViewBag.value2 = context.Blogs.Where(x => x.WriterId == writerId).Count();
            ViewBag.value3 = context.Categories.Count();
            //return View(User.Claims.ToList());
            return View();
        }


    }
}
