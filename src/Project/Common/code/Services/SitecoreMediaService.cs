﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Common.Web.Models;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using Sitecore.SecurityModel;

namespace Common.Web.Services
{
    public class SitecoreMediaService : ISitecoreMediaService
    {
        private readonly string masterDb = "master";

        public bool Upload(string itemPath, List<IMedia> mediaList)
        {
            int count = 0;
            foreach (var mlItem in mediaList)
            {
                if (UploadMediaItem(mlItem.Image, mlItem.FileName, itemPath, mlItem.Name))
                {
                    count++;
                }
            }

            if (count == mediaList.Count)
            {
                return true;
            }

            return false;
        }

        private bool UploadMediaItem(Stream stream, string fileName, string path, string mediaItemName)
        {
            if (string.IsNullOrWhiteSpace(fileName) || string.IsNullOrWhiteSpace(path) || string.IsNullOrWhiteSpace(mediaItemName))
            {
                Sitecore.Diagnostics.Log.Error($"Could not upload media item either filename, path or mediaitemname is null.", this);
                return false;
            }

            if (stream == Stream.Null)
            {
                Sitecore.Diagnostics.Log.Error($"Could not upload stream is null for media item {mediaItemName}.", this);
                return false;
            }
            
            string destination = $"{path}/{mediaItemName}";

            try
            {
                Sitecore.Resources.Media.MediaCreatorOptions options =
                    new Sitecore.Resources.Media.MediaCreatorOptions()
                    {
                        FileBased = false,
                        IncludeExtensionInItemName = false,
                        OverwriteExisting = true,
                        Versioned = false,
                        Destination = destination,
                        Database = Sitecore.Configuration.Factory.GetDatabase(masterDb),
                        AlternateText = mediaItemName
                    };

                using (new SecurityDisabler())
                {
                    Sitecore.Resources.Media.MediaCreator creator = new Sitecore.Resources.Media.MediaCreator();
                    MediaItem mediaItem = creator.CreateFromStream(stream, fileName, options);
                    if (mediaItem != null)
                    {
                        Log.Info($"Media Item {destination} uploaded successfully.",this);
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error($"Error uploading Media Item {destination}", ex, this);
            }
            finally
            {
                stream.Dispose();
            }

            return false;
        }
    }
}