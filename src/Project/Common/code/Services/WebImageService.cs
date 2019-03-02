using System;
using System.IO;
using System.Net;

namespace Common.Web.Services
{
    public class WebImageService : IImageService
    {
        public Func<WebClient> WebImageRequest = () => { return new WebClient(); };

        /// <summary>
        /// Get Image Stream from the web
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
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