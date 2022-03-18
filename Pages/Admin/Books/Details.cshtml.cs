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
    public class DetailsModel : PageModel
    {
        private readonly BooksWebSite.DataContext _context;

        public DetailsModel(BooksWebSite.DataContext context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Books.FirstOrDefaultAsync(m => m.id == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
