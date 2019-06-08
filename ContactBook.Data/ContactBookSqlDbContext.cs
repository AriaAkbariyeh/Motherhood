using ContactBook.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactBook.Data
{
    public class ContactBookSqlDbContext : DbContext
    {
        public ContactBookSqlDbContext(DbContextOptions<ContactBookSqlDbContext> options)
            : base(options)
        {

        }
        public DbSet<Contact> contacts{ get; set; }


    }
}
