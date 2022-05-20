namespace CurrentCultureSample;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
    {
		//initialize the static class and register a service here so the initial culture info is captured prior to first page loading.
        var cultureService = CultureDataService.Instance;

        //CultureDataService.Instance.SetCultureToAU();

        var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
            .Services.AddSingleton<CultureDataService>(sp => cultureService);

		var result = builder.Build();

		return result;
	}
}
