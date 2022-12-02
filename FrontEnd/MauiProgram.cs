using FrontEnd.Models;
using FrontEnd.ViewModels;
using FrontEnd.Views;

namespace FrontEnd;

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
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<ErrorReportListPage>();
        builder.Services.AddSingleton<ReportDescriptionPage>();
        builder.Services.AddSingleton<LoginPage>();

        builder.Services.AddSingleton<LoginPageViewModel>();

        return builder.Build();
	}
}
