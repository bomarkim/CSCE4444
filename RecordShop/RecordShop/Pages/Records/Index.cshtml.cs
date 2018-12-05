using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecordShop.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

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
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        //Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string RecordGenre { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> genreQuery = from m in _context.Record
                                               orderby m.Genre
                                               select m.Genre;

            var records = from m in _context.Record
                          select m;

            if(!String.IsNullOrEmpty(SearchString))
            {
                records = records.Where(s => s.Name.Contains(SearchString));
            }

            if (!String .IsNullOrEmpty(RecordGenre))
            {
                records = records.Where(x => x.Genre == RecordGenre);
            }

            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
            Record = await records.ToListAsync();
        }
    }
}
