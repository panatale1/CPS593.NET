using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Midterm2.Models.Mapping
{
    public class ContactMethodMap : EntityTypeConfiguration<ContactMethod>
    {
        public ContactMethodMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("ContactMethods");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.ContactsId).HasColumnName("ContactsId");
            this.Property(t => t.KeywordId).HasColumnName("KeywordId");
            this.Property(t => t.Contact_Id).HasColumnName("Contact_Id");

            // Relationships
            this.HasOptional(t => t.Contact)
                .WithMany(t => t.ContactMethods)
                .HasForeignKey(d => d.Contact_Id);
            this.HasRequired(t => t.Keyword)
                .WithMany(t => t.ContactMethods)
                .HasForeignKey(d => d.KeywordId);

        }
    }
}
