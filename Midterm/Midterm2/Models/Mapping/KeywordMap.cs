using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Midterm2.Models.Mapping
{
    public class KeywordMap : EntityTypeConfiguration<Keyword>
    {
        public KeywordMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Keywords");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.KeywordsId).HasColumnName("KeywordsId");
            this.Property(t => t.Parent_Id).HasColumnName("Parent_Id");

            // Relationships
            this.HasOptional(t => t.Keyword1)
                .WithMany(t => t.Keywords1)
                .HasForeignKey(d => d.Parent_Id);

        }
    }
}
