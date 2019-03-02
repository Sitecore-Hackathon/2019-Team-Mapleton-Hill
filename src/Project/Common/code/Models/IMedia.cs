using System.IO;

namespace Common.Web.Models
{
    public interface IMedia
    {
        string Name { get; set; }
        string FileName { get; set; }
        Stream Image { get; set; }
    }
}
