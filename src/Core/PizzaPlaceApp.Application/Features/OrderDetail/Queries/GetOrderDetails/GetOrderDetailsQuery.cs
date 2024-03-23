using MediatR;

namespace PizzaPlaceApp.Application.Features.OrderDetail.Queries.GetOrderDetails;

public record GetOrderDetailsQuery : IRequest<List<OrderDetailDto>>;