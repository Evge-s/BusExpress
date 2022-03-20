using BusExpress.Client;
using BusExpress.Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services
             .AddScoped<IAuthenticationService, AuthenticationService>()
             .AddScoped<IUserService, UserService>()
             .AddScoped<IHttpService, HttpService>()
             .AddScoped<ILocalStorageService, LocalStorageService>();

// configure http client
builder.Services.AddScoped(sp => new HttpClient() { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//builder.Services.AddScoped(sp => new HttpClient(new BackendHandler()) { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//builder.Services.AddScoped(x =>
//{
//    var apiUrl = new Uri(builder.Configuration["https://localhost:5176"]);

//    use fake backend if "fakeBackend" is "true" in appsettings.json
//    if (builder.Configuration["fakeBackend"] == "true")
//        return new HttpClient(new BackendHandler()) { BaseAddress = apiUrl };

//    return new HttpClient() { BaseAddress = apiUrl };
//});

var host = builder.Build();

var authenticationService = host.Services.GetRequiredService<IAuthenticationService>();
await authenticationService.Initialize();

await builder.Build().RunAsync();
