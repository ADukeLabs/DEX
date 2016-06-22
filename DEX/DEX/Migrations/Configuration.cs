namespace DEX.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DEX.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DEX.Models.ApplicationDbContext context)
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
                new City { Name = "Seattle" },
                new City { Name = "Boston" },
                new City { Name = "New York" },
                new City { Name = "Chicago" }
            );
            context.SaveChanges();

            context.Companies.AddOrUpdate(
                c => c.Name,
                new Company { Name = "Microsoft", Industry = "Software/Information Techonology", City = context.Cities.FirstOrDefault(x => x.Name == "Seattle") },
                new Company { Name = "Slalom Consluting", Industry = "Software/Information Technology", City = context.Cities.FirstOrDefault(x => x.Name == "Seattle") },
                new Company { Name = "Sandfield", Industry = "Software/Information Technology", City = context.Cities.FirstOrDefault(x => x.Name == "Auckland")},
                new Company { Name = "Xero", Industry = "Software/Information Technology", City = context.Cities.FirstOrDefault(x => x.Name == "Wellington, New Zealand")},
                new Company { Name = "Pariveda", Industry = "Consulting", City = context.Cities.FirstOrDefault(x => x.Name == "New York")}
            );

            context.SaveChanges();
        }
    }
}
