using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecordShop.Models
{
    public class CartItem
    {
        [Key]
        public string ItemId { get; set; }

        public int CartId { get; set; }

        public int Quantity { get; set; }

        public System.DateTime DateCreated { get; set; }

        public int RecordId { get; set; }

        public virtual Record Record { get; set; }
    }
}
