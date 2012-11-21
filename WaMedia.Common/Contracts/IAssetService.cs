﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WaMedia.Common.Models;
using Microsoft.WindowsAzure.MediaServices.Client;

namespace WaMedia.Common.Contracts
{
    public interface IAssetService
    {
        IMediaService MediaService { get; }

        IQueryable<Asset> Assets { get; }
        Asset GetAssetById(string assetId);
        [Obsolete("Dont use!")]
        string ThumbnailUrl(IAsset asset);
        void CreateAsset(string pathToFile);
        void CreateEmptyAsset(string name);
        void Publish(string assetId);
        void AssignThumbnail(string assetId);
        void DeleteAsset(string assetId);
        void Rename(string assetId, string newName);
        void CopyFromBlob(string destinationSasUri, string srcBlobSasUri);
    }
}
