using A2Test2.Authentication;
using Microsoft.AspNetCore.Components.WebView.Maui;
using A2Test2.Data;
using A2Test2.Helpers;
using A2Test2.Repository;
using Microsoft.AspNetCore.Components.Authorization;
using Blazorise;
using Blazorise.Bootstrap;

namespace A2Test2;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
    {
        
        var baseAddress = "https://beta.a2b2.org/";

        var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});
        builder.Services.AddSingleton(new HttpClient
        {
            BaseAddress = new Uri(baseAddress)
        });

        builder.Services.AddMauiBlazorWebView();
#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif



        builder.Services.AddHttpClient<HttpClientWithoutToken>(
            client => client.BaseAddress = new Uri(baseAddress));
        SecureStorage.Default.RemoveAll();

        builder.Services.AddScoped<IHttpService, HttpService>();
        builder.Services.AddScoped<IImagePostRepository, ImagePostRepository>();
        builder.Services.AddScoped<IAccountsRepository, AccountsRepository>();
        builder.Services.AddScoped<IUserRepository, UserRepository>();


        builder.Services.AddSingleton<WeatherForecastService>();

        builder.Services.AddAuthorizationCore();
        //builder.Services.AddScoped<JWTAuthenticationStateProvider>();
        //builder.Services.AddScoped<AuthenticationStateProvider>(s => s.GetRequiredService<JWTAuthenticationStateProvider>());
        //builder.Services.AddScoped<ILoginService, JWTAuthenticationStateProvider>(
        //    provider => provider.GetRequiredService<JWTAuthenticationStateProvider>()
        //);

        builder.Services.AddApiAuthorization()
            .AddAccountClaimsPrincipalFactory<RolesClaimsPrincipalFactory>();

        builder.Services.AddScoped<JWTAuthenticationStateProvider>();
        builder.Services.AddScoped<AuthenticationStateProvider, JWTAuthenticationStateProvider>(
            provider => provider.GetRequiredService<JWTAuthenticationStateProvider>()
        );

        builder.Services.AddScoped<ILoginService, JWTAuthenticationStateProvider>(
            provider => provider.GetRequiredService<JWTAuthenticationStateProvider>()
        );

        return builder.Build();
	}
}
