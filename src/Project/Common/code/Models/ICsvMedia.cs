using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Web.Models
{
    public interface ICsvMedia
    {
        string FileLocation { get; set; }

        string FileName { get; set; }

        string ItemName { get; set; }

        ResourceType Type { get; set; }
    }
}
