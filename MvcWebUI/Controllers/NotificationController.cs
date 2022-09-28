using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
    public class NotificationController : Controller
    {
        private NotificationManager notificationManager = new NotificationManager(new EfNotificationRepository());

        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult AllNotification()
        {
            var values = notificationManager.GetList();
            return View(values);

        }
    }
}
