using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace LocaleApp.Application;
public static class ApplicationRegistrar
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var assm=typeof(ApplicationRegistrar).Assembly;
        // Register application services here
        // Example: services.AddScoped<IMyService, MyService>();
        return services;
    }
}
