using Common.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Web.Providers
{
    public interface ICsvMediaProvider
    {
        List<ICsvMedia> GetMediaList(string fileLocation);
        ResourceType DetermineResourceType(string source);
    }
}
