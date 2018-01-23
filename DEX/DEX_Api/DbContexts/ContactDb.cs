using DEX_Api.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DEX_Api.DbContexts
{
    public class ContactDb : DbContext
    {
        public ContactDb() :
        base("DefaultConnection")
        {

        }

        public DbSet<Contact> Contacts { get; set; }
    }
}