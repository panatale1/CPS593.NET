using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Midterm2.Models.Mapping
{
    public class Contacts1Map : EntityTypeConfiguration<Contacts1>
    {
        public Contacts1Map()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.FirstName)
                .IsRequired();

            this.Property(t => t.LastName)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Contacts1");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.Keyword_Id).HasColumnName("Keyword_Id");

            // Relationships
            this.HasRequired(t => t.Keywords1)
                .WithMany(t => t.Contacts1)
                .HasForeignKey(d => d.Keyword_Id);

        }
    }
}
