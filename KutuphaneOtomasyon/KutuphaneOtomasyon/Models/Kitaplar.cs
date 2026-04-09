using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KutuphaneOtomasyon.Models;

[Table("Kitaplar")]
public partial class Kitaplar
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KitapAdi { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Yazar { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? YayinYili { get; set; }

    public bool? Durum { get; set; }

    [InverseProperty("Kitap")]
    public virtual ICollection<AlinanKitaplar> AlinanKitaplars { get; set; } = new List<AlinanKitaplar>();
}
