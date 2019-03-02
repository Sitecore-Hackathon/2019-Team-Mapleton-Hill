using System.IO;

namespace Common.Web.Models
{
    public class SimpleMedia : IMedia
    {
        public string Name { get; set; }

        public string FileName { get; set; }

        public Stream Image { get; set; }
    }
}