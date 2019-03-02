using Common.Web.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Common.Web.Services
{
    public class FileImageService : IImageService
    {
        public Stream GetImage(string path)
        {
            Stream imageStream = Stream.Null;

            FileInfo info = new FileInfo(path);
            if(!info.Exists)
            {
                Sitecore.Diagnostics.Log.Error($"Could not find image {path}", this);
                return Stream.Null;
            }

            try
            {
                using (FileStream fileStream = new FileStream(path, FileMode.Open))
                { 
                    if (fileStream.Length != 0)
                    {
                        fileStream.CopyTo(imageStream);
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Sitecore.Diagnostics.Log.Error($"Could not open image {path}", ex, this);
            }

            return imageStream;
        }
    }
}