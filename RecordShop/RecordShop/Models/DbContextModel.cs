using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RecordShop.Models
{
    public class DbContextModel
    {

        public class RecordShop_Context : DbContext
        {
            public RecordShop_Context(DbContextOptions<RecordShop_Context> options)
                : base(options)
            { }

            public RecordShop_Context() { }

            public DbSet<Customer> Customers { get; set; }
            public DbSet<Record> Records { get; set; }
            public DbSet<ShoppingCart> Carts { get; set; }
            public DbSet<CartItem> CartItems { get; set; }

            
        }

    }
}
