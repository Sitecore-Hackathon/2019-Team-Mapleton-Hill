using Common.Web.Models;
using System.Collections.Generic;

namespace Common.Web.Services
{
    public interface ISitecoreMediaService
    {
        bool Upload(string itemPath, List<IMedia> list);
    }
}
