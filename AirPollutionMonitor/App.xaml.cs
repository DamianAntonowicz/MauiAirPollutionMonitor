using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Graphics;
using Application = Microsoft.Maui.Controls.Application;

namespace AirPollutionMonitor
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			Microsoft.Maui.Handlers.CheckBoxHandler.CheckBoxMapper.AppendToMapping(nameof(IView.Background), (handler, view) =>
			{
#if WINDOWS
				handler.NativeView.Background = Colors.Pink.ToNative();
#elif __ANDROID__
				handler.NativeView.SetBackgroundColor(Colors.Red.ToNative());
#endif
			});
		}
	}
}
