// <copyright file="WhisperModelDownloadViewModel.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System.Collections.ObjectModel;
using Drastic.ViewModels;
using MauiWhisper.Models;
using MauiWhisper.Services;
using Microsoft.Maui.Adapters;

namespace MauiWhisper.ViewModels;

public class WhisperModelDownloadViewModel
    : BaseViewModel
{
    private WhisperModelService modelService;
    private IList<WhisperDownload> downloads = new ObservableCollection<WhisperDownload>();

    public WhisperModelDownloadViewModel(IServiceProvider services)
        : base(services)
    {
        this.modelService = services.GetService(typeof(WhisperModelService)) as WhisperModelService ??
                            throw new NullReferenceException(nameof(WhisperModelService));
        this.downloads = this.modelService.AllModels
            .Select(n => new WhisperDownload(n, this.modelService, this.Dispatcher)).ToList();
        this.Downloads = new VirtualListViewAdapter<WhisperDownload>(this.downloads);
    }

    public WhisperModelService ModelService => this.modelService;

    public VirtualListViewAdapter<WhisperDownload> Downloads { get; }
}