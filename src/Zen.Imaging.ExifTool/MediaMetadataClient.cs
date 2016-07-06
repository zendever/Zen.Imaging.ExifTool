using System;
using Zen.Imaging.ExifTool.Configuration;

namespace Zen.Imaging.ExifTool
{
    public class MediaMetadataClient : IMediaMetadataClient
    {
        public MediaMetadataClient(IMediaMetadataClientSettings settings)
        {
            Settings = settings;
        }

        protected IMediaMetadataClientSettings Settings { get; set; }

        public MediaMetadata GetMediaMetadata(string file)
        {
            throw new NotImplementedException();
        }
    }
}
