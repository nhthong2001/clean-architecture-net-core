using Demo.Domain.Share;
using MediatR;

namespace Demo.Application.Abstractions.Messages;
public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}
