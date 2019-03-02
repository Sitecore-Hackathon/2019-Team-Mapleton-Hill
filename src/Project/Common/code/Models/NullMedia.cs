using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Common.Web.Models
{
    public class NullMedia : IMedia
    {
        public string Name { get => string.Empty; set { } }
        public Stream Image { get => Stream.Null; set { } }
    }
}