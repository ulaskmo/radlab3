using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using radlab3._0.Data;
using radlab3._0.Models;

namespace radlab3._0.Pages
{
    public class IndexModel : PageModel
    {
        private readonly radlab3._0.Data.ApplicationDbContext _context;

        public IndexModel(radlab3._0.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Books.ToListAsync();
        }
    }
}
