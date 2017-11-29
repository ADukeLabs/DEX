using DEX_Api.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DEX_Api.DbContexts
{
    public class IdentityDb : DbContext
    {
        public IdentityDb() : base("DefaultConnection") { }

        public DbSet<ApplicationUser> Users { get; set; }
    }
}