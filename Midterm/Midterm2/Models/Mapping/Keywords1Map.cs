using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Midterm2.Models.Mapping
{
    public class Keywords1Map : EntityTypeConfiguration<Keywords1>
    {
        public Keywords1Map()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Keywords1");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Parent_Id).HasColumnName("Parent_Id");

            // Relationships
            this.HasRequired(t => t.Keywords12)
                .WithMany(t => t.Keywords11)
                .HasForeignKey(d => d.Parent_Id);

        }
    }
}
