using System.IO;

namespace Common.Web.Services
{
    public interface IImageService
    {
        Stream GetImage(string path);
    }
}
