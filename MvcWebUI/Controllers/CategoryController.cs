using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
