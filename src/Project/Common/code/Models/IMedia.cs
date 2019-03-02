using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Web.Models
{
    public interface IMedia
    {
        string Name { get; set; }
        Stream Image { get; set; }
    }
}
