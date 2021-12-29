using System;
using System.Linq;
using BusinessFunctionApp;
using Factories;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Services;

[assembly: FunctionsStartup(typeof(Startup))]

namespace BusinessFunctionApp
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddScoped<IBusinessService, BusinessService>();
            builder.Services.AddScoped<IBusinessFactory, BusinessFactory>();
        }
    }
}