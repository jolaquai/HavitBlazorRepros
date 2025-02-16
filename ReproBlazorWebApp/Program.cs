using Havit.Blazor.Components.Web;
using Havit.Blazor.Components.Web.Bootstrap;

using ReproBlazorWebApp.Components;

namespace ReproBlazorWebApp;
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddRazorComponents().AddInteractiveServerComponents();
        builder.Services.AddRazorPages();

        builder.Services.AddHxServices();
        builder.Services.AddHxMessenger();
        builder.Services.AddHxMessageBoxHost();

        var app = builder.Build();

        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
        }

        // The shit Microsoft doesn't tell you about when using RCLs
        app.UseAntiforgery();
        app.MapStaticAssets();
        app.UseStaticFiles();

        app.MapRazorComponents<App>().AddInteractiveServerRenderMode();
        app.MapRazorPages();

        app.Run();
    }
}
