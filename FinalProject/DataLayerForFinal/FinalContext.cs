using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerForFinal {
    public class FinalContext : DbContext{
            public DbSet<Person> People { get; set; }
            public DbSet<CType> Types { get; set; }
            public DbSet<Phone> Phones { get; set; }
            public DbSet<Address> Addresses { get; set; }
            public DbSet<Email> Emails { get; set; }
    }
}
