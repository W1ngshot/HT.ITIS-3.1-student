using Dotnet.Homeworks.DataAccess.Repositories;
using Dotnet.Homeworks.Domain.Abstractions.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Dotnet.Homeworks.DataAccess.Bootstrap;

public static class DataAccessServicesBootstrap
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IProductRepository, ProductRepository>();
        
        return services;
    }
}