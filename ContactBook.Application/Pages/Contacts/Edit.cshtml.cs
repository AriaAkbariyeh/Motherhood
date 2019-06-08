using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactBook.Core;
using ContactBook.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ContactBook.Application.Pages.Contacts
{
    public class EditModel : PageModel
    {
        private readonly IContactData contactData;
        private readonly IHtmlHelper htmlHelper;

        [BindProperty]
        public Contact contact { get; set; }

        public IEnumerable<SelectListItem> Nationalities{ get; set; }

        // IHtmlHelper is injected to build Nationalities Select List
        public EditModel(IContactData contactData,IHtmlHelper htmlHelper)
        {
            this.contactData = contactData;
            this.htmlHelper = htmlHelper;
        }
        public IActionResult OnGet(int? contactId)
        {
            Nationalities = htmlHelper.GetEnumSelectList<NationalityType>();
            if (contactId.HasValue)
            {
                contact = contactData.GetContactById(contactId.Value);
            }
            else
            {
                contact = new Contact();
            }

            if (contact == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Nationalities = htmlHelper.GetEnumSelectList<NationalityType>();
                return Page();
            }
            if(contact.Id > 0)
            {
                contactData.Update(contact);
                TempData["Message"] = "Contact has been updated.";

            }
            else
            {
                contactData.Add(contact);
                TempData["Message"] = "New Contact has been created.";
            }

            contactData.Commit();
            return RedirectToPage("./Detail", new { contactId = contact.Id });



        }
    }
}