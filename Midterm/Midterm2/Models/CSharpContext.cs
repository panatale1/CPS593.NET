using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Midterm2.Models.Mapping;

namespace Midterm2.Models
{
    public partial class CSharpContext : DbContext
    {
        static CSharpContext()
        {
            Database.SetInitializer<CSharpContext>(null);
        }

        public CSharpContext()
            : base("Name=CSharpContext")
        {
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<ContactMethod> ContactMethods { get; set; }
        //public DbSet<ContactMethods1> ContactMethods1 { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        //public DbSet<Contacts1> Contacts1 { get; set; }
        public DbSet<Keyword> Keywords { get; set; }
        //public DbSet<Keywords1> Keywords1 { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AddressMap());
            modelBuilder.Configurations.Add(new ContactMethodMap());
          //  modelBuilder.Configurations.Add(new ContactMethods1Map());
            modelBuilder.Configurations.Add(new ContactMap());
          //  modelBuilder.Configurations.Add(new Contacts1Map());
            modelBuilder.Configurations.Add(new KeywordMap());
          //  modelBuilder.Configurations.Add(new Keywords1Map());
        }
    }
}
