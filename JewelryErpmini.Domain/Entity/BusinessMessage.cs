using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryErpmini.Domain.Entity
{
    [Table("view_businessOrdersProgressMessage")]
    public class BusinessMessage
    {
        [Required]
        public int countTypeId { get; set; }
        [StringLength(16)]
        [Required]
        public string countType { get; set; }
        public int? total { get; set; }
    }
}
