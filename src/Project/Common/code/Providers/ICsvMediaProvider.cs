using Common.Web.Models;
using System.Collections.Generic;

namespace Common.Web.Providers
{
    public interface ICsvMediaProvider
    {
        List<ICsvMedia> ParseFile(string fileLocation);
    }
}
