using Common.Web.Models;
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

        public Func<WebClient> WebImageRequest = () => { return new WebClient(); };

        public Stream GetImage(string path)
        {
            Stream media = Stream.Null;
            Uri imageUri;
            if (!Uri.TryCreate(path, UriKind.Absolute, out imageUri))
            {
                Sitecore.Diagnostics.Log.Error($"Could not download image {path} because it is not a valid web address", this);
                return Stream.Null;
            }

            try
            {
                WebClient client = WebImageRequest.Invoke();
                byte[] data = client.DownloadData(path);
                media = new MemoryStream(data);
            }
            catch (WebException ex)
            {
                Sitecore.Diagnostics.Log.Error($"Could not download image {path}", ex, this);
            }

            return media;
        }
    }
}