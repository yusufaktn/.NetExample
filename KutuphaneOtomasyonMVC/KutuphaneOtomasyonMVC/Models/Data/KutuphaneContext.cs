using Microsoft.EntityFrameworkCore;

namespace KutuphaneOtomasyonMVC.Models.Data
{
    public class KutuphaneContext:DbContext
    {
        public KutuphaneContext(DbContextOptions<KutuphaneContext> options) : base(options)
        {
        }

        // Veritabanı tablolarına karşılık gelen DbSet'ler
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
         public DbSet<OduncVerme> OduncVermeKayitlari { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            base.OnModelCreating(modelBuilder);
        }
    }
}
