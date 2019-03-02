using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace Common.Web.Services
{
    public class WebImageService : IImageService, IDisposable
    {
        Stream _webStream = Stream.Null;

        public void Dispose()
        {
            _webStream.Dispose();
        }

        public Stream GetImage(string path)
        {
            Uri imageUri;
            if (!Uri.TryCreate(path, UriKind.Absolute, out imageUri))
            {
                Sitecore.Diagnostics.Log.Error($"Could not download image {path} because it is not a valid web address", this);
                return _webStream;
            }

            try
            {
                WebRequest request = WebRequest.Create(path);
                return request.GetResponse().GetResponseStream();
            }
            catch (WebException ex)
            {
                Sitecore.Diagnostics.Log.Error($"Could not download image {path}", ex, this);
            }

            return _webStream;
        }
    }
}