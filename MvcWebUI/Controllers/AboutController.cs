using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
	public class AboutController : Controller
    {
        private AboutManager aboutManager = new AboutManager(new EfAboutRepository());
		public IActionResult Index()
		{
            var values = aboutManager.GetList();
            return View(values);
		}

        public PartialViewResult SocialMediaAbout()
        {
            return PartialView();
        }
	}
}
