using Common.Web.Models;
using Common.Web.Providers;
using Common.Web.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Common.Web.Tests.Services
{
    public class BulkImageUploadServiceTests
    {
        [Fact]
        public void GivenUploadRequest_WhenCvsPathAndItemIsProvided_ReturnStream()
        {
            string csvPath = "C:\\HackathonTemp\\images.csv";
            string itemPath = "/sitecore/media library/Images";

            BulkMediaUploadService uploadSvc = new BulkMediaUploadService(new CsvMediaProvider(), new BulkMediaProviderBase(), new SitecoreMediaService());

            bool result =  uploadSvc.Upload(itemPath, csvPath);
            
            //assert
             Assert.True(result);
        }
    }
}
