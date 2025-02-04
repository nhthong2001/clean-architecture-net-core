using Demo.Application.Abstractions.Messages;

namespace Demo.Application.UseCases.V1.Queries.Product;
public class GetProductsQuery : IQuery<GetProductsResponse>
{
    public string Name { get; set; }
}
