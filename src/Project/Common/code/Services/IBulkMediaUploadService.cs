namespace Common.Web.Services
{
    interface IBulkMediaUploadService
    {
        bool Upload(string  itemPath, string csvFilePath);
    }
}
