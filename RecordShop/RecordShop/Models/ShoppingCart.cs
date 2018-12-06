using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecordShop.Models
{
    public partial class ShoppingCart
    {
       [Key]
       public int CartId { get; set; }
        public int Count { get; set; }
        public int RecordId { get; set; }
        public virtual Record Record { get; set; }

    }
}
