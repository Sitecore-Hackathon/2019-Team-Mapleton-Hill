using Cognifide.PowerShell.Commandlets;
using Common.Web.Providers;
using Common.Web.Services;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using System.Management.Automation;

namespace Common.Web.Commandlets
{
    [Cmdlet("Import", "ImagesFromDataFile")]
    public class GetImageData : BaseCommand
    {

        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string DataPath { get; set; }

        [Parameter(ValueFromPipeline = true, ValueFromPipelineByPropertyName = true)]
        public Item Item { get; set; }

        protected override void ProcessRecord()
        {
            if(!Item.Paths.IsMediaItem)
            {
                throw new PSInvalidOperationException("Bulk Image Upload can only be run on media items");
            }

            var provider = new CsvMediaProvider();
            var bulkProvider = new BulkMediaProviderBase();
            var sitecoreMediaService = new SitecoreMediaService();
            var mediaService = new BulkMediaUploadService(provider, bulkProvider, sitecoreMediaService);
            mediaService.Upload(Item.Paths.Path, DataPath);

            Log.Info(DataPath, this);
            Log.Info(Item.Paths.Path, this);
            base.ProcessRecord();
        }
    }
}