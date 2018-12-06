using RecordShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecordShop.ViewModels
{
    public class ShoppingCartViewModal
    {
        public Cart Cart { get; set; }
        public decimal CartTotal { get; set; }
    }
}
