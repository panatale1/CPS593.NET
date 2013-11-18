namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DataLayer.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<DataLayer.Models.CSharpContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataLayer.Models.CSharpContext context)
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

            //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT Keywords ON");
            context.Keywords.AddOrUpdate(
                new Keyword { Name = "Root", ParentId = 1 },
                new Keyword { Name = "Person Types", ParentId = 1 },
                new Keyword { Name = "Admin", ParentId = 2 }
                );
            context.SaveChanges();
            //context.Database.ExecuteSqlCommand("SET Identity_Insert Keywords OFF;");
            for (int i = 0; i < 1000; i++)
            {
                context.Contacts.AddOrUpdate(
                    new Contact { FirstName = "Mickey" + i, LastName = "Duck", KeywordId = 3 },
                    new Contact { FirstName = "Donald" + i, LastName = "Mouse", KeywordId = 3 }
                    );
            }
        }
    }
}
