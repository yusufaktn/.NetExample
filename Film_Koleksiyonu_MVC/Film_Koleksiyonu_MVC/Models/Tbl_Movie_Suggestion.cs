using System.ComponentModel.DataAnnotations;

namespace Film_Koleksiyonu_MVC.Models
{
    public class Tbl_Movie_Suggestion : BaseEntity
    {
        [Key]
        public Guid SuggestionId { get; set; }
        public Guid MovieId { get; set; }
        public Guid SuggestedByUserId { get; set; }
        public Guid SuggestedToUserId { get; set; }
        public string Note { get; set; }
        public bool IsRead { get; set; }

        // Navigation Properties
        public Tbl_Movie Movie { get; set; }
        public Tbl_User SuggestedByUser { get; set; }
        public Tbl_User SuggestedToUser { get; set; }
    }
}
