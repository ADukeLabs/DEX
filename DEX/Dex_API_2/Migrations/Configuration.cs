namespace Dex_API.Migrations
{
    using Dex_API.Models.DomainModels;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Dex_API.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Dex_API.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Cities.AddOrUpdate(
                c => c.Name,
                new City { Name = "Wellington" },
                new City { Name = "Auckland" },
                new City { Name = "Christchurch" }
            );
            context.SaveChanges();


            context.Companies.AddOrUpdate(
                c => c.Name,
                new Company { Name = "FINNZ", Address = "135 Victoria Street", City = context.Cities.FirstOrDefault(x => x.Id == 1)},
                new Company { Name = "SolNet", Address = "12/70 The Terrace", City = context.Cities.FirstOrDefault(x => x.Id == 1)}
            );

            context.SaveChanges();
        }
    }
}
