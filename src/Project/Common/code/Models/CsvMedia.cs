namespace Common.Web.Models
{
    public class CsvMedia : ICsvMedia
    {
        public string FileLocation { get; set; }

        public string FileName { get; set; }

        public string ItemName { get; set; }
    }
}