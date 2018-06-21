using BlazorState;
using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Browser.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace HomeOwnersAssociation.Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new BrowserServiceProvider(services =>
            {
                // Add any custom services here
                services.AddBlazorState(options =>
                {
                    options.UseReduxDevToolsBehavior = false; // See other demo on using ReduxDevTools
                    options.UseRouting = false; // See other demo on Routing.
                    options.UseCloneStateBehavior = true; // The basics.
                });
            });

            new BrowserRenderer(serviceProvider).AddComponent<App>("app");
        }
    }
}
