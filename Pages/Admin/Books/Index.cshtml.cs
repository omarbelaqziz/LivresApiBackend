using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BooksWebSite;
using Microsoft.AspNetCore.Authorization;

namespace BooksWebSite.Pages.Admin.Books
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly BooksWebSite.DataContext _context;

        public IndexModel(BooksWebSite.DataContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Books.ToListAsync();
        }
    }
}
