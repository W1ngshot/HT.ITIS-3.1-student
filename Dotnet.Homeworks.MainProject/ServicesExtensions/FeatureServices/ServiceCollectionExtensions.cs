using Dotnet.Homeworks.Features.Helpers;
using Dotnet.Homeworks.Infrastructure.UnitOfWork;

namespace Dotnet.Homeworks.MainProject.ServicesExtensions.FeatureServices;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddFeatureServices(this IServiceCollection services)
    {
        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssembly(AssemblyReference.Assembly);
        });
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        
        return services;
    }
}