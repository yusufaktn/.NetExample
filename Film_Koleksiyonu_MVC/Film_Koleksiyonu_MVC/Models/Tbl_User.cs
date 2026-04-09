using System.ComponentModel.DataAnnotations;

namespace Film_Koleksiyonu_MVC.Models
{
    public class Tbl_User : BaseEntity
    {
        [Key]
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? ProfileImage { get; set; }
        public string? About { get; set; }
        public string? ProfileImageUrl { get; set; }

        // Navigation Properties
        public ICollection<Tbl_Movie> Movies { get; set; }
        public ICollection<Tbl_Friend> SentFriendships { get; set; }
        public ICollection<Tbl_Friend> ReceivedFriendships { get; set; }
        public virtual ICollection<Tbl_Movie_Suggestion> SentSuggestions { get; set; }
        public virtual ICollection<Tbl_Movie_Suggestion> ReceivedSuggestions { get; set; }
        public virtual ICollection<Tbl_Approval> Approvals { get; set; }
    }
}
