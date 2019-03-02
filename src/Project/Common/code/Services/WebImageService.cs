using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace Common.Web.Services
{
    public class WebImageService : IWebImageService
    {
        public string Download(string imageUrl, string directoryDownload)
        {
            Uri imageUri;
            if(!Uri.TryCreate(imageUrl, UriKind.Absolute, out imageUri))
            {
                Sitecore.Diagnostics.Log.Error($"Could not download image {imageUrl} because it is not a valid web address", this);
                return string.Empty;
            }
            
            string fileName = System.IO.Path.GetFileName(imageUrl);
            string savePath = $"{directoryDownload}\\{fileName}";
            try
            {
                WebClient client = new WebClient();
                client.DownloadFile(imageUrl, savePath);
            }
            catch (WebException ex)
            {
                Sitecore.Diagnostics.Log.Error($"Could not download image {imageUrl}", ex, this);
            }
            return savePath;
        }
    }
}