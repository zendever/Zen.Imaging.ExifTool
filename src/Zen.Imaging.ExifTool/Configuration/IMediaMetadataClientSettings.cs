namespace Zen.Imaging.ExifTool.Configuration
{
    public interface IMediaMetadataClientSettings
    {
        string Command { get; }

        bool UseSingleQuotesForArguments { get; }
    }
}