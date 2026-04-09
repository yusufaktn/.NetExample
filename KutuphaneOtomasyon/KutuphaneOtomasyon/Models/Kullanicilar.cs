using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KutuphaneOtomasyon.Models;

[Table("Kullanicilar")]
public partial class Kullanicilar
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Ad { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Soyad { get; set; }

    [Unicode(false)]
    public string? SifreHash { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Mail { get; set; }

    [InverseProperty("Kullanici")]
    public virtual ICollection<AlinanKitaplar> AlinanKitaplars { get; set; } = new List<AlinanKitaplar>();
}
