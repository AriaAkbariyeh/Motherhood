using ContactBook.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactBook.Data
{
    class ContactBookSqlDbContext : DbContext
    {
        public DbSet<Contact> contacts{ get; set; }


    }
}
