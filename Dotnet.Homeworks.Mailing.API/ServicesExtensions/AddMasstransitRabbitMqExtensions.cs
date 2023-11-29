using Dotnet.Homeworks.Mailing.API.Configuration;
using Dotnet.Homeworks.Mailing.API.Consumers;
using MassTransit;

namespace Dotnet.Homeworks.Mailing.API.ServicesExtensions;

public static class AddMasstransitRabbitMqExtensions
{
    public static IServiceCollection AddMasstransitRabbitMq(this IServiceCollection services,
        IConfiguration configuration)
    {
        var rabbitConfig = configuration.GetSection("RabbitMqConfig").Get<RabbitMqConfig>()!;
        
        
        services.AddMassTransit(options =>
        {
            var host =
                $"amqp://{rabbitConfig.Username}:{rabbitConfig.Password}@{rabbitConfig.Hostname}:{rabbitConfig.Port}";
          
            options.UsingRabbitMq((context, configurator) =>
            {
                configurator.ConfigureEndpoints(context);
                configurator.Host(host);
            });
            options.AddConsumer<EmailConsumer>();
        });

        return services;
    }
}