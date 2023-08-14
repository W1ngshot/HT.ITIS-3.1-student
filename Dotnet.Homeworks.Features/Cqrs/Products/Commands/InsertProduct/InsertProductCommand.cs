namespace Dotnet.Homeworks.Features.Cqrs.Products.Commands.InsertProduct;

public class InsertProductCommand //TODO: Inherit certain interface 
{
    public string Name { get; init; }

    public InsertProductCommand(string name)
    {
        Name = name;
    }
}
