using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
