using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.ViewComponents.Writer
{
    public class WriterNotification :ViewComponent
    {
        private NotificationManager natificationManager = new NotificationManager(new EfNotificationRepository());

        public IViewComponentResult Invoke()
        {
            var values = natificationManager.GetList();
            return View(values);
        }

    }
}
