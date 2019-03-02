using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Common.Web.Models;

namespace Common.Web.Providers
{
    public class CvsMediaProvider : BulkMediaProviderBase, ICvsMediaProvider, IDisposable
    {
        private StreamReader _reader;

        public CvsMediaProvider(string fileLocation)
        {
            _reader = File.OpenText(fileLocation);
        }

        public void Dispose()
        {
            _reader.Dispose();
        }

        public override IEnumerable<T> GetMediaList<T>()
        {
            throw new NotImplementedException();
        }

        public ResourceType DetermineResourceType(string source)
        {
            throw new NotImplementedException();
        }
    }
}