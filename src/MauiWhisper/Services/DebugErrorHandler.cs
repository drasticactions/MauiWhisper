// <copyright file="DebugErrorHandler.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using Drastic.Services;

namespace MauiWhisper.Services;

public class DebugErrorHandler : IErrorHandlerService
{
    /// <inheritdoc/>
    public void HandleError(Exception ex)
    {
        System.Diagnostics.Debug.WriteLine(ex.Message);
    }
}