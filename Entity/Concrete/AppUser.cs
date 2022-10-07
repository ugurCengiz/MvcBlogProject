using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Entity.Concrete
{
    public class AppUser:IdentityUser<int>
    {
        public string NameSurName { get; set; }
        public string ImageUrl { get; set; }
    }
}
