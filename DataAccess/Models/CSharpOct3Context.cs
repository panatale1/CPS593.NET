using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DataAccess.Models.Mapping;

namespace DataAccess.Models
{
    public partial class CSharpOct3Context : DbContext
    {
        static CSharpOct3Context()
        {
            Database.SetInitializer<CSharpOct3Context>(null);
        }

        public CSharpOct3Context()
            : base("Name=CSharpOct3Context")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
