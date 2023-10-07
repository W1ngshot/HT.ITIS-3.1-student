using System.ComponentModel.DataAnnotations;

namespace Dotnet.Homeworks.MainProject.Dto;

public record RegisterUserDto([Required] string Name, [EmailAddress] [Required] string Email);