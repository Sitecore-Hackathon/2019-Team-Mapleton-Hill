using Common.Web.Models;
using Common.Web.Services;

namespace Common.Web.Factories
{
    public static class MediaFactory
    {
        public static IMedia Build(string path, string fileName, string name)
        {
            IImageService imageService = new WebImageService();
            IMedia media = new SimpleMedia()
             {
                  Name = name,
                  FileName = fileName,
                  Image = imageService.GetImage(path)
            };

            return media;
        }
    }
}