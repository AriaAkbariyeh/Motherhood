using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContactBook.Core;
using ContactBook.Data;

namespace ContactBook.Application.Pages.Contacts.C2
{
    public class DetailsModel : PageModel
    {
        private readonly ContactBook.Data.ContactBookDbContext _context;

        public DetailsModel(ContactBook.Data.ContactBookDbContext context)
        {
            _context = context;
        }

        public Contact Contact { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Contact = await _context.contacts.FirstOrDefaultAsync(m => m.Id == id);

            if (Contact == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
