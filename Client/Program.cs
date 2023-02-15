using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SuperDB.Client.Server;
using SuperDB.Client.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SuperDB.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            //so we register our service her
            builder.Services.AddScoped<ISuperHeroService, SuperHeroService>();// so this simply means that as soon as we inject Our ISuperHeroService 
            //interface we tell our app that we want to use "SuperHeroService" implementation class for that. This is also dependency injection 

            await builder.Build().RunAsync();
            //Building a Blazor WebAssembly with Crud and Web APi IN .Net5.
        }
    }
}
