namespace Zen.Imaging.ExifTool
{
    public interface IMediaMetadataClient
    {
        MediaMetadata GetMediaMetadata(string file);
    }
}