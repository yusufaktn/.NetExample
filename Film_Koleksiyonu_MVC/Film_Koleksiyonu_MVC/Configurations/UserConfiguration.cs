using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Film_Koleksiyonu_MVC.Models;

namespace Film_Koleksiyonu_MVC.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<Tbl_User>
    {
        public void Configure(EntityTypeBuilder<Tbl_User> builder)
        {
            builder.HasKey(u => u.UserId);

            builder.Property(u => u.UserId)
                .ValueGeneratedOnAdd();

            builder.Property(u => u.Username)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(u => u.ProfileImage)
                .HasMaxLength(200);

            builder.Property(u => u.ProfileImageUrl)
                .HasMaxLength(200);

            builder.Property(u => u.About)
                .HasMaxLength(500);

            // Movies ilişkisi
            builder.HasMany(u => u.Movies)
                .WithOne(m => m.User)
                .HasForeignKey(m => m.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // SentFriendships ilişkisi
            builder.HasMany(u => u.SentFriendships)
                .WithOne(f => f.User)
                .HasForeignKey(f => f.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // ReceivedFriendships ilişkisi
            builder.HasMany(u => u.ReceivedFriendships)
                .WithOne(f => f.FriendUser)
                .HasForeignKey(f => f.FriendId)
                .OnDelete(DeleteBehavior.Restrict);

            // SentSuggestions ilişkisi
            builder.HasMany(u => u.SentSuggestions)
                .WithOne(s => s.SuggestedByUser)
                .HasForeignKey(s => s.SuggestedByUserId)
                .OnDelete(DeleteBehavior.Restrict);

            // ReceivedSuggestions ilişkisi
            builder.HasMany(u => u.ReceivedSuggestions)
                .WithOne(s => s.SuggestedToUser)
                .HasForeignKey(s => s.SuggestedToUserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}