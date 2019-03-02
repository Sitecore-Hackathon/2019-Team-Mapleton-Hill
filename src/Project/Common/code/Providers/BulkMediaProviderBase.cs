using Common.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Common.Web.Factories;

namespace Common.Web.Providers
{
    public class BulkMediaProviderBase : IBulkMediaProvider
    {
        public List<IMedia> GetMediaList(List<ICsvMedia> sourceList)
        {
            List<IMedia> result = new List<IMedia>();
            foreach (var sourceItem in sourceList)
            {
                IMedia item = MediaFactory.Build(sourceItem.FileLocation, sourceItem.FileName, sourceItem.ItemName, sourceItem.Type);
                result.Add(item);
            }

            return result;
        }
    }
}