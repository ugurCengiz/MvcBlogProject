using System.Linq;
using System.Threading.Tasks;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.ViewComponents.Writer
{ 
   
    public class WriterAboutOnDashboard:ViewComponent
    {
        WriterManager writerManager = new WriterManager(new EfWriterRepository());
        
        Context context = new Context();
        
        public IViewComponentResult Invoke()
        {
           
            var userName = User.Identity.Name;
            ViewBag.veri = userName;
            var userMail = context.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = context.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterId).FirstOrDefault();
            var values = writerManager.GetWriterById(writerId);
            return View(values);
        }

    }
}
