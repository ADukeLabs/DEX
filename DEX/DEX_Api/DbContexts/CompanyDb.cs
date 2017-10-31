using DEX_Api.Models;
using System.Data.Entity;

namespace DEX_Api.DbContexts
{
    public class CompanyDb : DbContext
    {
        public CompanyDb() : 
            base("DefaultConnection")
        {

        }
        public DbSet<Company> Companies { get; set; }
    }
}