namespace AirPollutionMonitor;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		Microsoft.Maui.Handlers.CheckBoxHandler.Mapper.AppendToMapping(nameof(IView.Background), (handler, view) =>
		{
#if WINDOWS
			handler.PlatformView.Background = new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.Red);
#elif __ANDROID__
			handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Green);
#endif

			Routing.RegisterRoute(nameof(StationsPage), typeof(StationsPage));
			Routing.RegisterRoute(nameof(CodeSharingPage), typeof(CodeSharingPage));
			Routing.RegisterRoute(nameof(HandlersPage), typeof(HandlersPage));
			Routing.RegisterRoute(nameof(ImagePage), typeof(ImagePage));
		});
	}
}
