using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.Data.Items;

namespace Common.Web.Services
{
    interface IBulkMediaUploadService
    {
        bool Upload(string  itemPath, string csvFilePath);
    }
}
