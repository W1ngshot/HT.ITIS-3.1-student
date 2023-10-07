namespace Dotnet.Homeworks.Mailing.API.Dto;

public record EmailMessage(string Email, string Name, string? Subject, string Content);