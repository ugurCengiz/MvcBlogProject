using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminCommentController : Controller
    {
        CommentManager commentManager= new CommentManager(new EfCommentRepository());

        public IActionResult Index()
        {
            var values = commentManager.GetCommentWithBlog();
            return View(values);
        }

        public IActionResult DeleteComment(int id)
        {
            var value = commentManager.GetById(id);
            commentManager.Delete(value);
            return RedirectToAction("Index");
        }
    }
}
