using Havit.Blazor.Components.Web;
using Havit.Blazor.Components.Web.Bootstrap;

using HxToastDangerMessageProblem;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddHxServices();
builder.Services.AddHxMessageBoxHost();
builder.Services.AddHxMessenger();

await builder.Build().RunAsync();
