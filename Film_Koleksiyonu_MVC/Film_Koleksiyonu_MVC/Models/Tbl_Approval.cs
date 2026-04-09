using System.ComponentModel.DataAnnotations;

namespace Film_Koleksiyonu_MVC.Models
{
    public class Tbl_Approval : BaseEntity
    {
        [Key]
        public Guid ApprovalId { get; set; }

        [Required]
        public Guid MovieId { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public bool Status { get; set; }

        [Display(Name = "Yorum")]
        public string Comment { get; set; }

        // Navigation Properties
        public virtual Tbl_Movie Movie { get; set; }
        public virtual Tbl_User User { get; set; }
    }
}
