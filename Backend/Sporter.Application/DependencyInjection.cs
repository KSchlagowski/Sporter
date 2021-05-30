using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Sporter.Application.Interfaces;
using Sporter.Application.Services;
using Sporter.Application.Validators.Interfaces;
using Sporter.Application.Validators.Json;

namespace Sporter.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<IClientService, ClientService>();
            services.AddTransient<IItemService, ItemService>();
            services.AddTransient<IJsonService, JsonService>();
            services.AddTransient<IJsonValidator, JsonValidator>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}