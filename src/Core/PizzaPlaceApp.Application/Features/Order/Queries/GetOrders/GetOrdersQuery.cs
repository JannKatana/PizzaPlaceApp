using MediatR;

namespace PizzaPlaceApp.Application.Features.Order.Queries.GetOrders;

public record GetOrdersQuery : IRequest<List<OrderDto>>;