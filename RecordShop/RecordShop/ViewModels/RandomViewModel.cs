using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecordShop.Models;

namespace RecordShop.ViewModels
{
    public class RandomRecordViewModel
    {
        public Record Record { get; set; }
        public List<Customer> Customers { get; set; }
    }

    
}
