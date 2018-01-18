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
                new City { Name = "Seattle" },
                new City { Name = "New York" },
                new City { Name = "Chicago" },
                new City { Name = "Auckland" },
                new City { Name = "Wellington, New Zealand" }
            );
            context.SaveChanges();

            context.Companies.AddOrUpdate(
                c => c.Name,
                new Company
                {
                    Name = "Microsoft",
                    //Industry = "Software/Information Techonology",
                    City = context.Cities.FirstOrDefault(x => x.Name == "Seattle"),
                    Address = "One Microsoft Way, Redmond, WA 98052"
                },
                new Company
                {
                    Name = "Slalom Consluting",
                    //Industry = "Software/Information Technology",
                    City = context.Cities.FirstOrDefault(x => x.Name == "Seattle"),
                    Address = "821 2nd Avenue, Suite 1900 Seattle, WA 98104"
                },
                new Company
                {
                    Name = "Sandfield",
                    //Industry = "Software/Information Technology",
                    City = context.Cities.FirstOrDefault(x => x.Name == "Auckland"),
                    Address = "130 Ponsonby Rd, Grey Lynn, Auckland 1011, New Zealand"
                },
                new Company
                {
                    Name = "Xero",
                    //Industry = "Software/Information Technology",
                    City = context.Cities.FirstOrDefault(x => x.Name == "Wellington, New Zealand"),
                    Address = "3 Market Ln, Wellington, 6011, New Zealand"

                },
                new Company
                {
                    Name = "Compass",
                    //Industry ="Real Estate",
                    City = context.Cities.FirstOrDefault(x => x.Name == "New York"),
                    Address = "90 5th Ave."
                }

            );
            context.SaveChanges();

            //context.Contacts.AddOrUpdate(
            //    c => c.Name,
            //    new Contact
            //    {
            //        Name = "Eric Kim",
            //        Title = "Technical Recruiter",
            //        Company = context.Companies.FirstOrDefault(c => c.Name == "Microsoft"),
            //        Email = "eric@ms.com",
            //        PhoneNumber = "206-111-1111"
            //    },
            //    new Contact
            //    {
            //        Name = "Richard Cho",
            //        Title = "Technical Recruiter",
            //        Company = context.Companies.FirstOrDefault(c => c.Name == "Microsoft"),
            //        Email = "rich@ms.com",
            //        PhoneNumber = "206-000-000"
            //    },
            //    new Contact
            //    {
            //        Name = "Jake Erikson",
            //        Title = "Technology Recruiter",
            //        Company = context.Companies.FirstOrDefault(c => c.Name == "Slalom Consulting"),
            //        Email = "jake@somewhere.com",
            //        PhoneNumber = "206-000-0000"
            //    },
            //    new Contact
            //    {
            //        Name = "Ben Amor",
            //        Title = "CTO",
            //        Company = context.Companies.FirstOrDefault(c => c.Name == "Xero"),
            //        Email = "ben@somewhere.com",
            //        PhoneNumber = "04-000-000"
            //    }
            //);
            //context.SaveChanges();



            //context.Cities.AddOrUpdate(
            //    c => c.Name,
            //    new City { Name = "Wellington" },
            //    new City { Name = "Auckland" },
            //    new City { Name = "Christchurch" }
            //);
            //context.SaveChanges();


            //context.Companies.AddOrUpdate(
            //    c => c.Name,
            //    new Company { Name = "FINNZ", Address = "135 Victoria Street", City = context.Cities.FirstOrDefault(x => x.Id == 1)},
            //    new Company { Name = "SolNet", Address = "12/70 The Terrace", City = context.Cities.FirstOrDefault(x => x.Id == 1)}
            //);

            //context.SaveChanges();
        }
    }
}
