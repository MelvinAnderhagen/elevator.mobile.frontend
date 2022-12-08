using FrontEnd.Clients;
using FrontEnd.Models;
using FrontEnd.ViewModels;
using FrontEnd.Views;
using Microsoft.Extensions.DependencyInjection;

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

        builder.Services.AddScoped<LoginPage>();

		builder.Services.AddTransient<ApiClient>();

		builder.Services.AddHttpClient<ApiClient>(options =>
		{
			options.BaseAddress = new Uri("https://grupp5elevatorapidev.azurewebsites.net/api/");
		});/*.ConfigurePrimaryHttpMessageHandler(() => new LocalhostAndroidHttpsMessageHandler());*/

        builder.Services.AddSingleton<LoginPageViewModel>();
        builder.Services.AddTransient<ErrorReportListViewModel>();
        builder.Services.AddSingleton<BaseViewModel>();
		builder.Services.AddTransient<ReportDescriptionPage>();
		builder.Services.AddTransient<ErrorReportListPage>();

        return builder.Build();
	}
}
