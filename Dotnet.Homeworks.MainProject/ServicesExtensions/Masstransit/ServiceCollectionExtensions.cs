using Dotnet.Homeworks.MainProject.Configuration;
using MassTransit;

namespace Dotnet.Homeworks.MainProject.ServicesExtensions.Masstransit;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddMasstransitRabbitMq(this IServiceCollection services,
        RabbitMqConfig rabbitConfig)
    {
        services.AddMassTransit(options =>
        {
            Console.WriteLine($"amqp://{rabbitConfig.Username}:{rabbitConfig.Password}@{rabbitConfig.Hostname}:{rabbitConfig.Port}");
            var host =
                $"amqp://{rabbitConfig.Username}:{rabbitConfig.Password}@{rabbitConfig.Hostname}:{rabbitConfig.Port}";
            options.UsingRabbitMq((context, configurator) =>
            {
                configurator.ConfigureEndpoints(context);
                configurator.Host(host);
            });
        });

        return services;
    }
}