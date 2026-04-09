namespace Film_Koleksiyonu_MVC.Models
{
    public class BaseEntity
    {
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
        public bool Status { get; set; } = true;
    }
}
