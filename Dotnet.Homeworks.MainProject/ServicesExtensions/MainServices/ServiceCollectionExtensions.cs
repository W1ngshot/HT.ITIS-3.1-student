using Dotnet.Homeworks.MainProject.Services;

namespace Dotnet.Homeworks.MainProject.ServicesExtensions.MainServices;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddMainServices(this IServiceCollection services)
    {
        services.AddSingleton<IRegistrationService, RegistrationService>();
        services.AddSingleton<ICommunicationService, CommunicationService>();
        
        return services;
    }
}