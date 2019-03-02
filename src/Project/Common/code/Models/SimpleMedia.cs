using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Common.Web.Models
{
    public class SimpleMedia : IMedia
    {
        public string Name { get; set; }
        public Stream Image { get; set; }
        public ResourceType Source { get; set; }
    }
}