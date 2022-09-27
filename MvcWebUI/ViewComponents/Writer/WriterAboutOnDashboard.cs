using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.ViewComponents.Writer
{ 
   
    public class WriterAboutOnDashboard:ViewComponent
    {
        WriterManager writerManager = new WriterManager(new EfWriterRepository());

        public IViewComponentResult Invoke()
        {
            var values = writerManager.GetWriterById(1);
            return View(values);
        }

    }
}
