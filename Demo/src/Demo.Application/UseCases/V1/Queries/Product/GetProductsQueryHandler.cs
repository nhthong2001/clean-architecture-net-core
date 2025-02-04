using Demo.Application.Abstractions.Messages;
using Demo.Domain.Share;

namespace Demo.Application.UseCases.V1.Queries.Product;
public sealed class GetProductsQueryHandler : IQueryHandler<GetProductsQuery, GetProductsResponse>
{
    public Task<Result<GetProductsResponse>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
