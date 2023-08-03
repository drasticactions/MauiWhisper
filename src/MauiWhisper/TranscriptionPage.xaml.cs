using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Text;
using MauiWhisper.Tools;
using MauiWhisper.ViewModels;

namespace MauiWhisper;

public partial class TranscriptionPage : ContentPage
{
    private TranscriptionViewModel vm;
    private IServiceProvider provider;
    public TranscriptionPage(IServiceProvider provider)
    {
        InitializeComponent();
        this.provider = provider;
        this.BindingContext = this.vm = provider.GetRequiredService<TranscriptionViewModel>();
    }

    private void OnDownloadModelClicked(object sender, EventArgs e)
    {
        var page = new WhisperDownloadModelPage(this.provider);
        this.Navigation.PushModalAsync(page);
    }

    private async void OpenFileButtonClicked(object sender, EventArgs e)
    {
        PickOptions options = new()
        {
            PickerTitle = Translations.Common.OpenFileButton,
        };

        try
        {
            var result = await FilePicker.Default.PickAsync();
            if (result != null)
            {
                if (DrasticWhisperFileExtensions.VideoExtensions.Contains(Path.GetExtension(result.FileName)) 
                    || DrasticWhisperFileExtensions.AudioExtensions.Contains(Path.GetExtension(result.FileName)))
                {
                    this.vm.UrlField = result.FullPath;
                }
            }
        }
        catch (Exception ex)
        {
        }
    }
}