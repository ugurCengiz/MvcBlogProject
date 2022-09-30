using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
