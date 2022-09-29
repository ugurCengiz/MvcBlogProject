using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcWebUI.Controllers
{
    public class MessageController : Controller
    {
        private Message2Manager message2Manager = new Message2Manager(new EfMessage2Repository());
        [AllowAnonymous]
        public IActionResult InBox()
        {
            int id = 2;
            var values = message2Manager.GetInBoxListByWriter(id);
            return View(values);
        }

        [AllowAnonymous]
       
        public IActionResult MessageDetails(int id)
        {
            var value = message2Manager.GetById(id);
            return View(value);
        }
    }
}
