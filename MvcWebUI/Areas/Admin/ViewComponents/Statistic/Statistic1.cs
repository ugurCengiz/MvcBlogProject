using System.Linq;
using System.Xml.Linq;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1:ViewComponent
    {
        private BlogManager blogManager = new BlogManager(new EfBlogRepository());
        private Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = blogManager.GetList().Count;
            ViewBag.v2 = context.Contacts.Count();
            ViewBag.v3 = context.Comments.Count();


            string api = "d3494ca056c740e293c4e72988ba7b31";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument xDocument = XDocument.Load(connection);
            ViewBag.v4 = xDocument.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            return View();
        }
    }
}
