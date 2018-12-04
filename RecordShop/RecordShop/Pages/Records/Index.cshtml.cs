using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecordShop.Models;

namespace RecordShop.Records
{
    public class IndexModel : PageModel
    {
        private readonly RecordShop.Models.RecordShopContext _context;

        public IndexModel(RecordShop.Models.RecordShopContext context)
        {
            _context = context;
        }

        public IList<Record> Record { get;set; }

        public async Task OnGetAsync()
        {
            Record = await _context.Record.ToListAsync();
        }
    }
}
