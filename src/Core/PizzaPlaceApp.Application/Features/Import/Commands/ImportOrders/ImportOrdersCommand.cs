using MediatR;

namespace PizzaPlaceApp.Application.Features.Import.Commands.ImportOrders;

public class ImportOrdersCommand : IRequest<Unit>
{
    public Stream? Data { get; set; }
}