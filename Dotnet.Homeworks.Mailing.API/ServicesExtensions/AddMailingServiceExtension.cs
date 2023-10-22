using Dotnet.Homeworks.Mailing.API.Services;

namespace Dotnet.Homeworks.Mailing.API.ServicesExtensions;

public static class AddMailingServiceExtension
{
    public static IServiceCollection AddMailingService(this IServiceCollection services)
    {
        services.AddScoped<IMailingService, FakeMailingService>();
        return services;
    }
}