using System.ComponentModel.DataAnnotations;

namespace KutuphaneOtomasyonMVC.Models
{
    public class Kitap
    {
        [Key] 
        public int KitapID { get; set; }

        [Required(ErrorMessage = "ISBN alanı zorunludur.")]
        [StringLength(20)]
        public string? ISBN { get; set; }

        [Required(ErrorMessage = "Başlık alanı zorunludur.")]
        [StringLength(200)]
        public string? Baslik { get; set; }

        [StringLength(150)]
        public string? Yazar { get; set; }

        public int? YayinYili { get; set; }

        public ICollection<OduncVerme>? OduncVermeKayitlari { get; set; }

        public Kitap()
        {
            OduncVermeKayitlari = new HashSet<OduncVerme>();
        }
        //ICollection<OduncVerme>? OduncVermeKayitlari: Bir kitabın sahip olduğu tüm ödünç verme kayıtlarını tutar.
        //HashSet<T> ile başlatmak, null referans hatalarını önler.

    }
}
