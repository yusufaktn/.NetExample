using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Film_Koleksiyonu_MVC.Models;

namespace Film_Koleksiyonu_MVC.Configurations
{
    public class ApprovalConfiguration : IEntityTypeConfiguration<Tbl_Approval>
    {
        public void Configure(EntityTypeBuilder<Tbl_Approval> builder)
        {
            builder.HasKey(a => a.ApprovalId);

            builder.Property(a => a.ApprovalId)
                .ValueGeneratedOnAdd();

            builder.Property(a => a.Status)
                .IsRequired();

            builder.Property(a => a.MovieId)
                .IsRequired();

            builder.Property(a => a.UserId)
                .IsRequired();

            // Movie ilişkisi
            builder.HasOne(a => a.Movie)
                .WithMany(m => m.Approvals)
                .HasForeignKey(a => a.MovieId)
                .OnDelete(DeleteBehavior.Restrict);

            // User ilişkisi
            builder.HasOne(a => a.User)
                .WithMany(u => u.Approvals)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}