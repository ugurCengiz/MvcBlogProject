using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace MvcWebUI.ViewComponents.Writer
{
    public class WriterMessageNotification: ViewComponent
    {
        private Message2Manager message2Manager = new Message2Manager(new EfMessage2Repository());
         Context context = new Context();
        public IViewComponentResult Invoke()
        {
            var userName = User.Identity.Name;
            var userMail = context.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = context.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterId).FirstOrDefault();

            var values = message2Manager.GetInBoxListByWriter(writerId);
            return View(values);

        }
    }
}
