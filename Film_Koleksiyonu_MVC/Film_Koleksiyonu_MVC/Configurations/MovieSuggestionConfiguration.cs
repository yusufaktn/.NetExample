using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Film_Koleksiyonu_MVC.Models;

namespace Film_Koleksiyonu_MVC.Configurations
{
    public class MovieSuggestionConfiguration : IEntityTypeConfiguration<Tbl_Movie_Suggestion>
    {
        public void Configure(EntityTypeBuilder<Tbl_Movie_Suggestion> builder)
        {
            builder.HasKey(ms => ms.SuggestionId);

            builder.Property(ms => ms.SuggestionId)
                .ValueGeneratedOnAdd();

            builder.Property(ms => ms.Status)
                .IsRequired();

            builder.Property(ms => ms.MovieId).IsRequired();
            builder.Property(ms => ms.SuggestedByUserId).IsRequired();
            builder.Property(ms => ms.SuggestedToUserId).IsRequired();
            builder.Property(ms => ms.IsRead).IsRequired();
            builder.Property(ms => ms.Note).HasMaxLength(500);

            // Movie ilişkisi
            builder.HasOne(ms => ms.Movie)
                .WithMany(m => m.Suggestions)
                .HasForeignKey(ms => ms.MovieId)
                .OnDelete(DeleteBehavior.Restrict);

            // SuggestedByUser ilişkisi
            builder.HasOne(ms => ms.SuggestedByUser)
                .WithMany(u => u.SentSuggestions)
                .HasForeignKey(ms => ms.SuggestedByUserId)
                .OnDelete(DeleteBehavior.Restrict);

            // SuggestedToUser ilişkisi
            builder.HasOne(ms => ms.SuggestedToUser)
                .WithMany(u => u.ReceivedSuggestions)
                .HasForeignKey(ms => ms.SuggestedToUserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}