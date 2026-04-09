using System.ComponentModel.DataAnnotations;

namespace Film_Koleksiyonu_MVC.Models
{
    public class Tbl_Movie : BaseEntity
    {
        [Key]
        public Guid MovieId { get; set; }

        [Required(ErrorMessage = "Film adı zorunludur.")]
        [Display(Name = "Film Adı")]
        public string Title { get; set; }

        [Display(Name = "Açıklama")]
        public string Description { get; set; }

        [Display(Name = "Film Posteri")]
        public string? ImageUrl { get; set; }

        [Display(Name = "Yayın Tarihi")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Kategori seçimi zorunludur.")]
        [Display(Name = "Kategori")]
        public Guid CategoryId { get; set; }

        [Display(Name = "Puan")]
        [Range(0, 5, ErrorMessage = "Puan 0-5 arasında olmalıdır.")]
        public int Rating { get; set; }

        [Required]
        public Guid UserId { get; set; }

        // Navigation Properties
        public virtual Tbl_Category Category { get; set; }
        public virtual Tbl_User User { get; set; }
        public virtual ICollection<Tbl_Movie_Suggestion> Suggestions { get; set; }
        public virtual ICollection<Tbl_Approval> Approvals { get; set; }
    }
}
