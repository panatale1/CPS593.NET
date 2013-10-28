namespace Midterm2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Midterm2.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Midterm2.Models.CSharpContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Midterm2.Models.CSharpContext context)
        {

            context.Addresses.AddOrUpdate(
                new Address { StreetAddress = "5 Montrose Lane", City = "Wapingers Falls", State = "NY", Zip = "12590", ContactId = 1 },
                new Address { StreetAddress = "184 Osborne Hill Road", City = "Fishkill", State = "NY", Zip = "12524", ContactId = 2 }
                );
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
        }
    }
}
