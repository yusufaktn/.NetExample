using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Film_Koleksiyonu_MVC.Models;

namespace Film_Koleksiyonu_MVC.Configurations
{
    public class MovieConfiguration : IEntityTypeConfiguration<Tbl_Movie>
    {
        public void Configure(EntityTypeBuilder<Tbl_Movie> builder)
        {
            builder.HasKey(m => m.MovieId);

            // MovieId otomatik oluşturulacak
            builder.Property(m => m.MovieId)
                .ValueGeneratedOnAdd();

            builder.Property(m => m.Title)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(m => m.Description)
                .HasMaxLength(500);

            builder.Property(m => m.ImageUrl)
                .HasMaxLength(200);

            builder.Property(m => m.CategoryId)
                .IsRequired();

            builder.Property(m => m.UserId)
                .IsRequired();

            builder.Property(m => m.Rating)
                .IsRequired();

            // Category ilişkisi
            builder.HasOne(m => m.Category)
                .WithMany(c => c.Movie)
                .HasForeignKey(m => m.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            // User ilişkisi
            builder.HasOne(m => m.User)
                .WithMany(u => u.Movies)
                .HasForeignKey(m => m.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // Suggestions ilişkisi
            builder.HasMany(m => m.Suggestions)
                .WithOne(s => s.Movie)
                .HasForeignKey(s => s.MovieId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}