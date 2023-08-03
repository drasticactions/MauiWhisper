// <copyright file="IOnlineVideoService.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

namespace MauiWhisper.Services;

public interface IOnlineVideoService
{
    bool IsValidUrl(string url);

    Task<string> GetAudioUrlAsync(string url);
}