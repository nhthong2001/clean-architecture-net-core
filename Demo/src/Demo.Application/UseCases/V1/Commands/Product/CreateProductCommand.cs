using Demo.Application.Abstractions.Messages;

namespace Demo.Application.UseCases.V1.Commands.Product;
public class CreateProductCommand : ICommand
{
    public string Name { get; set; }
}
