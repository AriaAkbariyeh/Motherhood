using ContactBook.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactBook.Data
{
    public class ContactBookDbContext : DbContext
    {
        public ContactBookDbContext(DbContextOptions<ContactBookDbContext> options)
            : base(options)
        {

        }
        public DbSet<Contact> contacts{ get; set; }


    }
}
