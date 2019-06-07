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
    public class ListModel : PageModel
    {
        

        private readonly IContactData contactData;

        public IEnumerable<Contact> contacts{ get; set; }

        [BindProperty(SupportsGet =true)]
        public string SearchTerm { get; set; }

        public ListModel(IContactData contactData)
        {
            this.contactData = contactData;
        }
        public void OnGet()
        {
            // TODO: Make Search Non Case-Sensetive!!
            contacts = contactData.GetContactsByName(SearchTerm);
        }
    }
}