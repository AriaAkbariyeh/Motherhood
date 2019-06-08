using System;
using System.Collections.Generic;
using System.Text;
using ContactBook.Core;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ContactBook.Data
{
    public class SqlContactData : IContactData
    {
        private readonly ContactBookSqlDbContext db;

        public SqlContactData(ContactBookSqlDbContext db)
        {
            this.db = db;
        }

        public Contact Add(Contact contact)
        {
            db.contacts.Add(contact);
            return contact;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public Contact Delete(int Id)
        {
            var contact = GetContactById(Id);
            if(contact != null)
            {
                db.contacts.Remove(contact);
            }

            return contact;
        }

        public Contact GetContactById(int Id)
        {
            return db.contacts.Find(Id);
        }

        public IEnumerable<Contact> GetContactsByName(string name)
        {
            var query = from c in db.contacts
                        where c.Name.StartsWith(name) || string.IsNullOrEmpty(name)
                        orderby c.Name
                        select c;
            return query;
        }

        public int GetCountOfContacts()
        {
            return db.contacts.Count();
        }

        public Contact Update(Contact updatedContact)
        {
            var entity = db.contacts.Attach(updatedContact);
            entity.State = EntityState.Modified;
            return updatedContact;

        }
    }
}
