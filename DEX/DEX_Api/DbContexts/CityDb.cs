using DEX_Api.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DEX_Api.DbContexts
{
    public class CityDb : DbContext
    {
        public CityDb() : 
            base("DefaultConnection")
        {

        }
        public DbSet<City> Cities { get; set; }
    }
}