using Demo.Application.Abstractions.Messages;
using Demo.Domain.Share;

namespace Demo.Application.UseCases.V1.Commands.Product;
public sealed class CreateProductCommandHandler : ICommandHandler<CreateProductCommand>
{
    public Task<Result> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
