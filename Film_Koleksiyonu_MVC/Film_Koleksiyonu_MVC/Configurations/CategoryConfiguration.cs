using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Film_Koleksiyonu_MVC.Models;

namespace Film_Koleksiyonu_MVC.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Tbl_Category>
    {
        public void Configure(EntityTypeBuilder<Tbl_Category> builder)
        {
            builder.HasKey(c => c.CategoryId);

            builder.Property(c => c.CategoryId)
                .ValueGeneratedOnAdd();

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Movies ilişkisi
            builder.HasMany(c => c.Movie)
                .WithOne(m => m.Category)
                .HasForeignKey(m => m.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}