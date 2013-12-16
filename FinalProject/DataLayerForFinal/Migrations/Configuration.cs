namespace DataLayerForFinal.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataLayerForFinal.FinalContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataLayerForFinal.FinalContext context)
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
            context.Types.AddOrUpdate(
                new CType { TypeName = "Admin" },
                new CType { TypeName="User"},
                new CType { TypeName="Home"},
                new CType { TypeName="Cell"},
                new CType { TypeName="Work"},
                new CType { TypeName="Personal"},
                new CType { TypeName="School"}
                );
            context.People.AddOrUpdate(
                new Person { PID=1,LastName="Natale",FirstName="Peter",Type="Admin"},
                new Person { PID=2, LastName="Bond",FirstName="James",Type="User"},
                new Person { PID=3, LastName="Anastasi", FirstName="Elizabeth",Type="User"}
                );
            context.Emails.AddOrUpdate(
                new Email { EID = 1, EmailAddress = "natalep1@hawkmail.newpaltz.edu", PersonID = 1, Type = "School" },
                new Email { EID = 2, EmailAddress = "panatale1@gmail.com", PersonID = 1, Type = "Personal" },
                new Email { EID = 3, EmailAddress = "pnatale@grinnell-library.org", PersonID = 1, Type = "Work" },
                new Email { EID = 4, EmailAddress = "DoubleOhSeven@MI6.gov.uk", PersonID = 2, Type = "Work" },
                new Email{EID = 5, EmailAddress = "eaanastasi@gmail.com", PersonID=3, Type="Personal"}
            );
            context.Phones.AddOrUpdate(
                new Phone { PhID=1, PhoneNumber="18452272807",PersonID=1,Type="Home"},
                new Phone { PhID=2, PhoneNumber="19147724030", PersonID=1, Type="Cell"},
                new Phone { PhID = 3, PhoneNumber="18452973428", PersonID=1, Type="Work"},
                new Phone { PhID=4, PhoneNumber="07981555555",PersonID=2,Type="Work"},
                new Phone { PhID = 5, PhoneNumber="18452359468", PersonID=3, Type="Cell"}
                );
            context.Addresses.AddOrUpdate(
                new Address { AID=1,Street="5 Montrose Lane", City="Wappingers Falls", State="NY", ZIP="12590",PersonID=1,Type="Home"},
                new Address { AID=2, Street="2642 East Main Street", City="Wappingers Falls", State="NY", ZIP = "12590", PersonID=1,Type="Work"},
                new Address { AID = 3, Street="102 Popula Blvd", City="Wappingers Falls", State = "NY", ZIP = "12590", PersonID=3}
                );
        }
    }
}
