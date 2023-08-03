using Drastic.Services;

namespace MauiWhisper.Services;

public class DebugErrorHandler : IErrorHandlerService
{
    public void HandleError(Exception ex)
    {
        System.Diagnostics.Debug.WriteLine(ex.Message);
    }
}