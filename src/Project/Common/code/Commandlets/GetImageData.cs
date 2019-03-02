using Cognifide.PowerShell.Commandlets;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Web;

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
            Log.Info(DataPath, this);
            Log.Info(Item.Paths.Path, this);
            base.ProcessRecord();
        }
    }
}