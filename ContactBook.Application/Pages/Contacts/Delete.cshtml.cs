using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactBook.Core;
using ContactBook.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContactBook.Application.Pages.Contacts
{
    public class DeleteModel : PageModel
    {
        private readonly IContactData contactData;

        public Contact Contact{ get; set; }
        public DeleteModel(IContactData contactData)
        {
            this.contactData = contactData;
        }
        public IActionResult OnGet(int contactId)
        {
            Contact = contactData.GetContactById(contactId);
            if(Contact == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

        public IActionResult OnPost(int contactId)
        {
            var contact = contactData.Delete(contactId);
            contactData.Commit();
            if (Contact == null)
            {
                return RedirectToPage("./NotFound");
            }
            TempData["Message"] = "The Contact has been succesfully deleted.";
            return RedirectToPage("./List");
        }
    }
}