using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RecordShop.Models
{
    public class RecordShopContext : DbContext
    {
        public RecordShopContext()
        {
        }

        public RecordShopContext (DbContextOptions<RecordShopContext> options)
            : base(options)
        {
        }

        public DbSet<RecordShop.Models.Record> Record { get; set; }
    }
}
