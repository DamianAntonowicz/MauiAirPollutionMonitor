namespace AirPollutionMonitor;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(IView.Background), (handler, view) =>
		{
#if WINDOWS
			handler.PlatformView.Background = new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.Red);
#elif ANDROID
			handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Green);
#endif
		});
	}
}
