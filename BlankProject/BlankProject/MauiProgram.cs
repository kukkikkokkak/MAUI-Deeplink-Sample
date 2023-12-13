using Microsoft.Extensions.Logging;

namespace BlankProject
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            Console.WriteLine($"MauiProgram: CreateMauiApp {DateTime.Now}");
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}