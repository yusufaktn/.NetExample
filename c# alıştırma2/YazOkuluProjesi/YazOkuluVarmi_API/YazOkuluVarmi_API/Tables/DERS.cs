using Dapper.Contrib.Extensions;

namespace YazOkuluVarmi_API.Tables
{
    [Table("DERS")]
    public class DERS
    {
        [Key]
        public int ID { get; set; }
        public string AD { get; set; }= string.Empty;
        public string KREDI { get; set; } = string.Empty;
        public string AKTS { get; set; } = string.Empty;
        public string BKOD { get; set; } = string.Empty;

    }
}
