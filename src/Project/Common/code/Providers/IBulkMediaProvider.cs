using Common.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Web.Providers
{
    public interface IBulkMediaProvider
    {
        List<IMedia> GetMediaList(List<ICsvMedia> sourceList);
    }
}
