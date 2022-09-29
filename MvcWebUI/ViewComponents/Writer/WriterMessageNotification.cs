using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.ViewComponents.Writer
{
    public class WriterMessageNotification: ViewComponent
    {
        private Message2Manager message2Manager = new Message2Manager(new EfMessage2Repository());
        public IViewComponentResult Invoke()
        {
            int id = 2;
            var values = message2Manager.GetInBoxListByWriter(id);
            return View(values);
        }
    }
}
