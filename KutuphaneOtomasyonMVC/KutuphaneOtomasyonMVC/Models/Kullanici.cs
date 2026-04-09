using System.ComponentModel.DataAnnotations;

namespace KutuphaneOtomasyonMVC.Models
{
    public class Kullanici
    {
        [Key]
        public int KullaniciID { get; set; }

        [Required]
        [StringLength(50)]
        public string? Ad { get; set; }

        [Required]
        [StringLength(50)]
        public string? Soyad { get; set; }

        [Required]
        [EmailAddress]
        public string? Eposta { get; set; }

        [Required]
        public string? SifreHash { get; set; } 

        
         public string Rol { get; set; } = "Uye"; 

        
         public virtual ICollection<OduncVerme>? OduncVerilenKitaplar { get; set; }
    }
}
