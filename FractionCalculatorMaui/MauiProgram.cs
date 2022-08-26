using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Markup;
using FractionCalculatorMaui.ViewModels;

namespace FractionCalculatorMaui;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>().ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        }).UseMauiCommunityToolkit().UseMauiCommunityToolkitMarkup();
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainPageViewModel>();
        return builder.Build();
    }
}