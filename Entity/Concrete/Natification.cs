using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Natification
    {
        [Key]
        public int NatificationId { get; set; }
        public string NatificationType { get; set; }
        public string NatificationTypeSymbol { get; set; }
        public string NatificationColor { get; set; }
        public string NatificationDetails { get; set; }
        public bool NatificationStatus { get; set; }
        public DateTime NatificationDate { get; set; }
        
    }
}
