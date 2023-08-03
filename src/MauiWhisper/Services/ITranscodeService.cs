namespace MauiWhisper.Services;

/// <summary>
/// Transcode Service.
/// </summary>
public interface ITranscodeService
{
    string BasePath { get; }

    /// <summary>
    /// Process file.
    /// </summary>
    /// <param name="filePath">File Path.</param>
    /// <returns>Path to transcoded file.</returns>
    Task<string> ProcessFile(string filePath);
}