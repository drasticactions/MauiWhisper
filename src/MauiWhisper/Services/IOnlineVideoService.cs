namespace MauiWhisper.Services;

public interface IOnlineVideoService
{
    bool IsValidUrl(string url);

    Task<string> GetAudioUrlAsync(string url);
}