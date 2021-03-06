﻿using ContactBook.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactBook.Data
{
    public interface IContactData
    {
        IEnumerable<Contact> GetContactsByName(string name);
        Contact GetContactById(int Id);

        Contact Update(Contact updatedContact);

        Contact Add(Contact contact);

        Contact Delete(int Id);

        int GetCountOfContacts();

        int Commit();
    }

}
