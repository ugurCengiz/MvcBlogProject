using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Areas.Admin.Models;

namespace MvcWebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();
            list.Add(new CategoryClass
            {
                CategoryName = "Teknoloji",
                CategoryCount = 14
            });
            list.Add(new CategoryClass
            {
                CategoryName = "Yazılım",
                CategoryCount = 10
            });
            list.Add(new CategoryClass
            {
                CategoryName = "Spor",
                CategoryCount = 6
            });
            return Json(new { jsonlist = list });
        }
    }
}
