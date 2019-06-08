using ContactBook.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactBook.Application.Pages.Contacts.ViewComponents
{
    public class ContactCountViewComponent : ViewComponent
    {
        private readonly IContactData contactData;

        public ContactCountViewComponent(IContactData contactData)
        {
            this.contactData = contactData;
        }

        public IViewComponentResult Invoke()
        {
            var count = contactData.GetCountOfContacts();
            return View(count);
        }
    }
}
