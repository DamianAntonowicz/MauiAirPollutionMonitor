using AirPollutionMonitor.Services;
using AirPollutionMonitor.ViewModels;
using Refit;

namespace AirPollutionMonitor;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddSingleton(RestService.For<IGiosApi>("https://api.gios.gov.pl"));
		builder.Services.AddTransient<StationsViewModel>();
		builder.Services.AddTransient<StationsPage>();

		return builder.Build();
	}
}
