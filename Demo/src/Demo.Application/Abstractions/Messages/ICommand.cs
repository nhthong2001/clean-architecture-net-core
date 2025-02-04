using Demo.Domain.Share;
using MediatR;

namespace Demo.Application.Abstractions.Messages;
public interface ICommand : IRequest<Result>
{
}

public interface ICommand<TResponse> : IRequest<Result<TResponse>>
{
}
