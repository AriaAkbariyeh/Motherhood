using ContactBook.Core;
using System.Collections.Generic;
using System.Linq;

namespace ContactBook.Data
{
    public class InMemoryContactData : IContactData
    {
        List<Contact> contacts;

        public InMemoryContactData()
        {
            contacts = new List<Contact>
            {
                new Contact { Id = 1, Name = "Aria Ak", Address="Wangsa Maju Av.", Nationality=NationalityType.Iranian, Number="01167702424" },
                new Contact { Id = 2, Name = "Bob Doe", Address="WallStreet", Nationality=NationalityType.Russian, Number="01812803034" },
                new Contact { Id = 3, Name = "Alice Marley", Address="Intermark", Nationality=NationalityType.Polish, Number="01754541001" },
                new Contact { Id = 4, Name = "Jacky Chan", Address="Menara Binjai", Nationality=NationalityType.Chinese, Number="0123881280" }
            };
        }

        public IEnumerable<Contact> GetAll()
        {
            return from c in contacts
                   orderby c.Name
                   select c;
        }

    }

}
