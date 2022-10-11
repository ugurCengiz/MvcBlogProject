using System.ComponentModel.DataAnnotations;

namespace MvcWebUI.Areas.Admin.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage ="Lütfen Rol Adı Giriniz")]
        public string Name { get; set; }       

    }
}
