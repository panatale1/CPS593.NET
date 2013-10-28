using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataStuff.Models.Mapping
{
    public class AddressMap : EntityTypeConfiguration<Address>
    {
        public AddressMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Addresses");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.StreetAddress).HasColumnName("StreetAddress");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Zip).HasColumnName("Zip");
            this.Property(t => t.ContactId).HasColumnName("ContactId");

            // Relationships
            this.HasRequired(t => t.Contact)
                .WithMany(t => t.Addresses)
                .HasForeignKey(d => d.ContactId);

        }
    }
}
