using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.ViewComponents.Writer
{
    public class WriterNotification :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
