using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Common.Web.Models
{
    public class CsvMedia : ICsvMedia
    {
        public string FileLocation { get; set; }

        public string FileName { get; set; }

        public string ItemName { get; set; }

        public ResourceType Type { get; set; }
    }
}