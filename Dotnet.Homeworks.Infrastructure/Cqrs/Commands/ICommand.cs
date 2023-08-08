using Dotnet.Homeworks.Infrastructure.Utils;
using Dotnet.Homeworks.Mediator;

namespace Dotnet.Homeworks.Infrastructure.Cqrs.Commands;

public interface ICommand : IRequest<Result>
{
    public Result Result { get; set; }
}

public interface ICommand<TResponse> : IRequest<Result<TResponse>>
{
    public Result<TResponse> Result { get; init; }
}