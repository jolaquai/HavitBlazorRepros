using Havit.Blazor.Components.Web;
using Havit.Blazor.Components.Web.Bootstrap;

using Microsoft.AspNetCore.Components;

namespace HxToastDangerMessageProblem.Pages;

partial class Index
{
    private HxMessageBoxService messenger;
    [Inject]
    public IHxMessengerService Messenger
    {
        get; set;
    }

    private void AddError(string message)
    {
        Messenger.AddMessage(new BootstrapMessengerMessage()
        {
            AutohideDelay = 10000,
            // crashes while building the render tree due a Region being opened, right after which the data-bs-theme="dark" attribute cannot be added
            // ref: 
            Color = ThemeColor.Danger,
            Title = "Error",
            Text = message
        });
    }

    private void AddWarning(string message)
    {
        Messenger.AddMessage(new BootstrapMessengerMessage()
        {
            AutohideDelay = 6000,
            Color = ThemeColor.Warning,
            Title = "Warning",
            Text = message
        });
    }
}
