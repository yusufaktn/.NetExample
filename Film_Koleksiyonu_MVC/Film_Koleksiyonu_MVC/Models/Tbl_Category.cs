using System.ComponentModel.DataAnnotations;

namespace Film_Koleksiyonu_MVC.Models
{
    public class Tbl_Category:BaseEntity
    {
        [Key]
        public Guid CategoryId { get; set; }
        public string Name { get; set; }

        public ICollection<Tbl_User> Users { get; set; }
        public ICollection<Tbl_Movie> Movie { get; set; }
    }
}
