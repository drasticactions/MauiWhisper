// <copyright file="App.xaml.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

namespace MauiWhisper;

public partial class App : Application
{
    public App(IServiceProvider provider)
    {
        this.InitializeComponent();
        this.MainPage = new TranscriptionPage(provider);
    }
}
