using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.ViewComponents.Writer
{
    public class WriterMessageNotification: ViewComponent
    {
        private MessageManager messageManager = new MessageManager(new EfMessageRepository());
        public IViewComponentResult Invoke()
        {
            string p;
            p = "ugurcengiz1@gmail.com";
            var values = messageManager.GetInBoxListByWriter(p);
            return View(values);
        }
    }
}
