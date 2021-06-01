using Microsoft.Extensions.DependencyInjection;
using Sporter.Domain.Interfaces;
using Sporter.Infrastructure.Repositories;

namespace Sporter.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IClientRepository, ClientRepository>();
            services.AddTransient<IItemRepository, ItemRepository>();

            return services;
        }
    }
}