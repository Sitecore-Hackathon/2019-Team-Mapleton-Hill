using Common.Web.Factories;
using Common.Web.Models;
using System.Collections.Generic;

namespace Common.Web.Providers
{
    public class BulkMediaProvider : IBulkMediaProvider
    {
        /// <summary>
        /// Get List of Image items to be saved in the Media Library
        /// </summary>
        /// <param name="sourceList"></param>
        /// <returns></returns>
        public List<IMedia> GetMediaList(List<ICsvMedia> sourceList)
        {
            List<IMedia> result = new List<IMedia>();
            foreach (var sourceItem in sourceList)
            {
                IMedia item = MediaFactory.Build(sourceItem.FileLocation, sourceItem.FileName, sourceItem.ItemName);
                result.Add(item);
            }

            return result;
        }
    }
}