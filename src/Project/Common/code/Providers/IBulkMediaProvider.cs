using Common.Web.Models;
using System.Collections.Generic;

namespace Common.Web.Providers
{
    public interface IBulkMediaProvider
    {
        List<IMedia> GetMediaList(List<ICsvMedia> sourceList);
    }
}
