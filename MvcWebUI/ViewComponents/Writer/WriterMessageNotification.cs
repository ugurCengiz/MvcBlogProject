using Business.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.ViewComponents.Writer
{
    public class WriterMessageNotification: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
