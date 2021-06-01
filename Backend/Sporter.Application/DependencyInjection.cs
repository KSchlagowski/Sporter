using System.Reflection;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Sporter.Application.Interfaces;
using Sporter.Application.Services;
using Sporter.Application.Validators.Client.ViewModels;
using Sporter.Application.Validators.Interfaces;
using Sporter.Application.Validators.Json;
using Sporter.Application.Validators.ViewModels.Client;
using Sporter.Application.Validators.ViewModels.Item;
using Sporter.Application.ViewModels.Client;
using Sporter.Application.ViewModels.Item;

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

            services.AddTransient<IValidator<NewAddressVm>, NewAddressValidator>();
            services.AddTransient<IValidator<NewClientContactInformationVm>, NewClientContactInformationValidator>();
            services.AddTransient<IValidator<NewClientVm>, NewClientValidator>();
            services.AddTransient<IValidator<NewItemVm>, NewItemValidator>();

            return services;
        }
    }
}