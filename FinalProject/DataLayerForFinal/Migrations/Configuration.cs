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
                new CType { TID = 1, TypeName = "Admin" },
                new CType { TID = 2, TypeName="User"},
                new CType { TID=3, TypeName="Home"},
                new CType { TID = 4, TypeName="Cell"},
                new CType { TID=5, TypeName="Work"},
                new CType { TID=6,TypeName="Personal"},
                new CType{TID=7, TypeName="School"}
                );
            context.People.AddOrUpdate(
                new Person { PID=1,LastName="Natale",FirstName="Peter",Type=1},
                new Person { PID=2, LastName="Bond",FirstName="James",Type=2}
                );
            context.Emails.AddOrUpdate(
                new Email {EID=1, EmailAddress="natalep1@hawkmail.newpaltz.edu",PersonID=1, Type=7 },
                new Email { EID=2, EmailAddress="panatale1@gmail.com",PersonID=1,Type=6},
                new Email { EID=3, EmailAddress="pnatale@grinnell-library.org", PersonID=1, Type=5},
                new Email { EID=4, EmailAddress="DoubleOhSeven@MI6.com", PersonID=2, Type=5}
            );
            context.Phones.AddOrUpdate(
                new Phone { PhID=1, PhoneNumber="18452272807",PersonID=1,Type=3},
                new Phone { PhID=2, PhoneNumber="19147724030", PersonID=1, Type=4},
                new Phone { PhID = 3, PhoneNumber="18452973428", PersonID=1, Type=5},
                new Phone { PhID=4, PhoneNumber="07981555555",PersonID=2,Type=5}
                );
            context.Addresses.AddOrUpdate(
                new Address { AID=1,Street="5 Montrose Lane", City="Wappingers Falls", State="NY", ZIP="12590",PersonID=1,Type=3},
                new Address { AID=2, Street="2642 East Main Street", City="Wappingers Falls", State="NY", ZIP = "12590", PersonID=1,Type=5}
                );
        }
    }
}
