namespace Common.Web.Models
{
    public interface ICsvMedia
    {
        string FileLocation { get; set; }

        string FileName { get; set; }

        string ItemName { get; set; }
    }
}
