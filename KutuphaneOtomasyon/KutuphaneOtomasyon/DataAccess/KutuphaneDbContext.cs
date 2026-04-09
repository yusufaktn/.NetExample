using System;
using System.Collections.Generic;
using KutuphaneOtomasyon.Models;
using Microsoft.EntityFrameworkCore;

namespace KutuphaneOtomasyon.DataAccess;

public partial class KutuphaneDbContext : DbContext
{
    public KutuphaneDbContext()
    {
    }

    public KutuphaneDbContext(DbContextOptions<KutuphaneDbContext> options) : base(options)
    {
    }

    public virtual DbSet<AlinanKitaplar> AlinanKitaplars { get; set; }

    public virtual DbSet<Kitaplar> Kitaplars { get; set; }

    public virtual DbSet<Kullanicilar> Kullanicilars { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=DESKTOP-1623\\MSSQLSERVER1;Database=KutuphaneOtomasyonDB;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AlinanKitaplar>(entity =>
        {
            entity.HasOne(d => d.Kitap).WithMany(p => p.AlinanKitaplars).HasConstraintName("FK_AlinanKitaplar_Kitaplar");

            entity.HasOne(d => d.Kullanici).WithMany(p => p.AlinanKitaplars).HasConstraintName("FK_AlinanKitaplar_Kullanicilar");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
