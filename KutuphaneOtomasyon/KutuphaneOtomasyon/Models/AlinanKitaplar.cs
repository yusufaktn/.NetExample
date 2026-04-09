using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KutuphaneOtomasyon.Models;

[Table("AlinanKitaplar")]
public partial class AlinanKitaplar
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("KullaniciID")]
    public int? KullaniciId { get; set; }

    [Column("KitapID")]
    public int? KitapId { get; set; }

    [ForeignKey("KitapId")]
    [InverseProperty("AlinanKitaplars")]
    public virtual Kitaplar? Kitap { get; set; }

    [ForeignKey("KullaniciId")]
    [InverseProperty("AlinanKitaplars")]
    public virtual Kullanicilar? Kullanici { get; set; }
}
