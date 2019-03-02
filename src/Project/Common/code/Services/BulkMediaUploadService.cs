using Common.Web.Providers;

namespace Common.Web.Services
{
    /// <summary>
    /// BulkMediaUploadService is the main service that bulk upload process of images from the web 
    /// </summary>
    public class BulkMediaUploadService : IBulkMediaUploadService
    {
        private readonly ICsvMediaProvider _csvMediaProvider;
        private readonly IBulkMediaProvider _bulkMediaProvider;
        private readonly ISitecoreMediaService _sitecoreMediaService;

        public BulkMediaUploadService(ICsvMediaProvider csvMediaProvider, IBulkMediaProvider bulkMediaProvider, ISitecoreMediaService sitecoreMediaService)
        {
            _csvMediaProvider = csvMediaProvider;
            _bulkMediaProvider = bulkMediaProvider;
            _sitecoreMediaService = sitecoreMediaService;
        }

        public bool Upload(string itemPath, string csvFilePath)
        {
            bool result = false;
            var csvMediaList = _csvMediaProvider.ParseFile(csvFilePath);
            if (csvMediaList == null)
            {
                return false;
            }

           var iMediaList = _bulkMediaProvider.GetMediaList(csvMediaList);
           if (iMediaList == null)
           {
               return false;
           }

           result = _sitecoreMediaService.Upload(itemPath, iMediaList);

            return result;
        }
    }
}