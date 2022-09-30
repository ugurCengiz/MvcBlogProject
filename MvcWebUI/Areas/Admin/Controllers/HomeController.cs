using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
