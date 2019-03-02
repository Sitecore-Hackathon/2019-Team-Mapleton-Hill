using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Web.Services
{
    public interface IWebImageService
    {
        string Download(string imageUrl, string directoryDownload);
    }
}
