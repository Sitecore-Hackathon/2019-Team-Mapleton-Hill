using Common.Web.Models;
using Common.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Common.Web.Factories
{
    public static class MediaFactory
    {
        public static IMedia Build(string path, string name, ResourceType resourceType)
        {
            IMedia media = new NullMedia();
            IImageService imageService;

            switch(resourceType)
            {
                case ResourceType.FileSystem:
                    imageService = new FileImageService();
                    media = new SimpleMedia()
                    {
                        Name = name,
                        Source = resourceType,
                        Image = imageService.GetImage(path)
                    };
                    break;
                case ResourceType.Web:
                    imageService = new WebImageService();
                    media = new SimpleMedia()
                    {
                        Name = name,
                        Source = resourceType,
                        Image = imageService.GetImage(path)
                    };
                    break;
            }

            return media;
        }
    }
}