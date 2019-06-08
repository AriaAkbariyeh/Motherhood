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
    public class IndexModel : PageModel
    {
        private readonly ContactBook.Data.ContactBookDbContext _context;

        public IndexModel(ContactBook.Data.ContactBookDbContext context)
        {
            _context = context;
        }

        public IList<Contact> Contact { get;set; }

        public async Task OnGetAsync()
        {
            Contact = await _context.contacts.ToListAsync();
        }
    }
}
