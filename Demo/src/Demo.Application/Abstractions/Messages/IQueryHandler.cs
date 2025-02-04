using Demo.Domain.Share;
using MediatR;

namespace Demo.Application.Abstractions.Messages;
public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>> where TQuery : IQuery<TResponse>
{
}
