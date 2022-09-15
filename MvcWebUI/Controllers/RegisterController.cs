using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
    public class RegisterController : Controller
    {
        private WriterManager writerManager = new WriterManager(new EfWriterDal());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Writer writer)
        {
            writer.WriterStatus = true;
            writer.WriterAbout = "Deneme Test";
            writerManager.WriterAdd(writer);
            return RedirectToAction("Index", "Blog");
        }
    }
}
