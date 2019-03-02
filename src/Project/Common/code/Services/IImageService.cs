using Common.Web.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Web.Services
{
    public interface IImageService
    {
        Stream GetImage(string path);
    }
}
