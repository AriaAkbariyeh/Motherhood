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
    public class DetailModel : PageModel
    {
        private readonly IContactData contactData;

        public Contact contact { get; set; }

        public DetailModel(IContactData contactData)
        {
            this.contactData = contactData;
        }

        public void OnGet(int contactId)
        {
            contact = contactData.GetContactById(contactId);
        }
    }
}