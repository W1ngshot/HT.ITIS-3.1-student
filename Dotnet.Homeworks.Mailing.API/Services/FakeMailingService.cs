using Dotnet.Homeworks.Mailing.API.Configuration;
using Dotnet.Homeworks.Mailing.API.Dto;
using Dotnet.Homeworks.Shared.Dto;
using Microsoft.Extensions.Options;

namespace Dotnet.Homeworks.Mailing.API.Services;

public class FakeMailingService : IMailingService
{
    private readonly EmailConfig _emailConfig;

    public FakeMailingService(IOptions<EmailConfig> emailConfig)
    {
        _emailConfig = emailConfig.Value;
    }

    public async Task<Result> SendEmailAsync(EmailMessage emailDto)
    {
        Console.WriteLine($"Config mail: {_emailConfig.Email}");
        Console.WriteLine($"{emailDto.Name} {emailDto.Email} {emailDto.Subject ?? ""} {emailDto.Content}");
        return new Result(true);
    }
}