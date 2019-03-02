using Common.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Common.Web.Providers
{
    public abstract class BulkMediaProviderBase
    {
        public abstract IEnumerable<T> GetMediaList<T>() where T : IMedia;
    }
}