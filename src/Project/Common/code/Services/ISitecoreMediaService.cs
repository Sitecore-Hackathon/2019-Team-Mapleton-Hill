using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Web.Services
{
    public interface ISitecoreMediaService
    {
        bool Upload(Item parent);
    }
}
