using System.ComponentModel.DataAnnotations;

namespace Film_Koleksiyonu_MVC.Models
{
    public class Tbl_Friend : BaseEntity
    {
        [Key]
        public Guid FriendshipId { get; set; }
        public Guid UserId { get; set; }
        public Guid FriendId { get; set; }
        public bool IsApproved { get; set; }

        // Navigation Properties
        public Tbl_User User { get; set; }
        public Tbl_User FriendUser { get; set; }
    }
}
