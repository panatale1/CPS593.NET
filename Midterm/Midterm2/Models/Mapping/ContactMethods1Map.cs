using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Midterm2.Models.Mapping
{
    public class ContactMethods1Map : EntityTypeConfiguration<ContactMethods1>
    {
        public ContactMethods1Map()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("ContactMethods1");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Contacts_Id).HasColumnName("Contacts_Id");
            this.Property(t => t.Keywords_Id).HasColumnName("Keywords_Id");

            // Relationships
            this.HasRequired(t => t.Contacts1)
                .WithMany(t => t.ContactMethods1)
                .HasForeignKey(d => d.Contacts_Id);
            this.HasRequired(t => t.Keywords1)
                .WithMany(t => t.ContactMethods1)
                .HasForeignKey(d => d.Keywords_Id);

        }
    }
}
