using JobSearch.Services;
using JobSearch.ViewModels;
using JobSearch.Views;

namespace JobSearch;

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

				fonts.AddFont("Roboto-Bold.ttf", "RobotoBold");
				fonts.AddFont("Roboto-Medium.ttf", "RobotoMedium");
				fonts.AddFont("Roboto-Regular.ttf", "RobotoRegular");
				fonts.AddFont("materialdesignicons-webfont.ttf", "IconFont");
			});

		builder.Services.AddTransient<MainPage>();
		builder.Services.AddTransient<MainPageViewModel>();
		builder.Services.AddTransient<FirstPage>();
		builder.Services.AddTransient<FirstPageViewModel>();
		builder.Services.AddTransient<DetailPage>();
		builder.Services.AddTransient<DetailPageViewModel>();
		 
		builder.Services.AddSingleton<INavigationService, NavigationService>();

		return builder.Build(); 
	}
}

