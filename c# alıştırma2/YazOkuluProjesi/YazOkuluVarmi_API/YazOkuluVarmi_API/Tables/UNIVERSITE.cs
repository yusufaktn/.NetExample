using Dapper.Contrib.Extensions;

namespace YazOkuluVarmi_API.Tables
{
    [Table("UNIVERSITE")]
    public class UNIVERSITE
    {
        [Key]
        public string BKOD { get; set; } = string.Empty;
        public string AD { get; set; } = string.Empty;

    }
}
