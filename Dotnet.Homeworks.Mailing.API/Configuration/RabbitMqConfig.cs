namespace Dotnet.Homeworks.Mailing.API.Configuration;

public class RabbitMqConfig
{
    public required string Username { get; set; }
    
    public required string Password { get; set; }
    
    public required string Hostname { get; set; }
    
    public int Port { get; set; }
}