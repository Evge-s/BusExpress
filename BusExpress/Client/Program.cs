using BusExpress.Client;
using BusExpress.Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services
             .AddScoped<IAuthenticationService, AuthenticationService>()
             .AddScoped<ILocalStorageService, LocalStorageService>()
             .AddScoped<IHttpService, HttpService>()
             .AddScoped<IUserService, UserService>();

// configure http client
builder.Services.AddScoped(sp => new HttpClient() { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

var host = builder.Build();

var authenticationService = host.Services.GetRequiredService<IAuthenticationService>();
await authenticationService.Initialize();

await builder.Build().RunAsync();
