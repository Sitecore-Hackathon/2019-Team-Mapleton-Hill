using Common.Web.Models;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Web.Services
{
    public interface ISitecoreMediaService
    {
     //   bool UploadMediaItem(Stream stream, string fileName, string path, string mediaItemName);

        bool Upload(Item originItem, List<IMedia> list);
    }
}
