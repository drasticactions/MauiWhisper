namespace MauiWhisper;

public partial class App : Application
{
	public App(IServiceProvider provider)
	{
		InitializeComponent();

		MainPage = new TranscriptionPage(provider);
	}
}
