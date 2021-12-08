using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Microsoft.Maui.Controls.Xaml;
using Application = Microsoft.Maui.Controls.Application;

namespace AirPollutionMonitor
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
		}
	}
}
