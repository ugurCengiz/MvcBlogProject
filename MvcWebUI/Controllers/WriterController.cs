using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
   public class WriterController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WriterProfile()
        {
            return View();
        }

        [Authorize]
        public IActionResult WriterMail()
        {
            return View();
        }
    }
}
