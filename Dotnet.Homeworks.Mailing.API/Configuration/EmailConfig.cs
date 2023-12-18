namespace Dotnet.Homeworks.Mailing.API.Configuration;

public class EmailConfig
{
    public required string Email { get; set; }
    public required string Host { get; set; }
    public int Port { get; set; }
    public required string Password { get; set; }
}