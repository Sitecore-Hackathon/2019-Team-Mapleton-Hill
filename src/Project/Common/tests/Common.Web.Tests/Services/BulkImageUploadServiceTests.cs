using Common.Web.Providers;
using Common.Web.Services;
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

            BulkMediaUploadService uploadSvc = new BulkMediaUploadService(new CsvMediaProvider(), new BulkMediaProvider(), new SitecoreMediaService());

            bool result =  uploadSvc.Upload(itemPath, csvPath);
            
            //assert
             Assert.True(result);
        }
    }
}
