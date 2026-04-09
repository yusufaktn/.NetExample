using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Film_Koleksiyonu_MVC.Models;

namespace Film_Koleksiyonu_MVC.Configurations
{
    public class FriendConfiguration : IEntityTypeConfiguration<Tbl_Friend>
    {
        public void Configure(EntityTypeBuilder<Tbl_Friend> builder)
        {
            builder.HasKey(f => f.FriendId);

            builder.Property(f => f.FriendId)
                .ValueGeneratedOnAdd();

            builder.Property(f => f.Status)
                .IsRequired();

            // User ilişkisi (gönderen)
            builder.HasOne(f => f.User)
                .WithMany(u => u.SentFriendships)
                .HasForeignKey(f => f.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // FriendUser ilişkisi (alan)
            builder.HasOne(f => f.FriendUser)
                .WithMany(u => u.ReceivedFriendships)
                .HasForeignKey(f => f.FriendId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}