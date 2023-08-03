using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiWhisper.ViewModels;

namespace MauiWhisper;

public partial class WhisperDownloadModelPage : ContentPage
{
    private WhisperModelDownloadViewModel vm;
    
    public WhisperDownloadModelPage(IServiceProvider provider)
    {
        InitializeComponent();
        this.BindingContext = this.vm = provider.GetRequiredService<WhisperModelDownloadViewModel>();
    }

    private async void CloseModal(object sender, EventArgs e)
    {
        await this.Navigation.PopModalAsync();
    }
}