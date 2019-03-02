using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Common.Web.Services
{
    public class FileImageService : IImageService, IDisposable
    {
        private Stream _fileStream;

        public void Dispose()
        {
            _fileStream.Dispose();
        }

        public Stream GetImage(string path)
        {
            throw new NotImplementedException();
        }
    }
}