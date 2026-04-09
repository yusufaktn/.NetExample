using Microsoft.EntityFrameworkCore;
using Film_Koleksiyonu_MVC.Models;
using Film_Koleksiyonu_MVC.Configurations;

namespace Film_Koleksiyonu_MVC.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Tbl_User> Users { get; set; }
        public DbSet<Tbl_Movie> Movies { get; set; }
        public DbSet<Tbl_Category> Categories { get; set; }
        public DbSet<Tbl_Friend> Friends { get; set; }
        public DbSet<Tbl_Movie_Suggestion> MovieSuggestions { get; set; }
        public DbSet<Tbl_Approval> Approvals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new MovieConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new FriendConfiguration());
            modelBuilder.ApplyConfiguration(new MovieSuggestionConfiguration());
            modelBuilder.ApplyConfiguration(new ApprovalConfiguration());

            // Seed verileri ekleniyor

        }
    }
}