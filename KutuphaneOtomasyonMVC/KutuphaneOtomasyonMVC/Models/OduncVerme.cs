using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KutuphaneOtomasyonMVC.Models
{
    public class OduncVerme
    {
        [Key]
        public int OduncVermeID { get; set; }

        
        [Required]
        public int KitapID { get; set; } 

        [Required]
        public int KullaniciID { get; set; } 

        [Required]
        public DateTime OduncAlmaTarihi { get; set; }

        public DateTime? IadeTarihi { get; set; } 

        
        [ForeignKey("KitapID")] 
        public virtual Kitap? Kitap { get; set; }

       
        [ForeignKey("KullaniciID")] 
        public virtual Kullanici? Kullanici { get; set; }

        // Yapıcı Metot (Constructor) - Ödünç alma tarihi otomatik atansın
        public OduncVerme()
        {
            OduncAlmaTarihi = DateTime.Now; // Kayıt oluşturulduğunda o anki tarih atansın
        }
    }
}
