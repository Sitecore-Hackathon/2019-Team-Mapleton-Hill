using Cognifide.PowerShell.Commandlets;
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

        protected override void ProcessRecord()
        {
            Log.Info(DataPath, this);
            base.ProcessRecord();
        }
    }
}