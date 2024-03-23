using MediatR;

namespace PizzaPlaceApp.Application.Features.Import.Commands.ImportOrderDetails;

public class ImportOrderDetailsCommand : IRequest<Unit>
{
    public Stream? Data { get; set; }
}