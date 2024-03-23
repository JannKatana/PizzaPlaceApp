using PizzaPlaceApp.Application.Contracts.Persistence;

using AutoMapper;
using MediatR;

namespace PizzaPlaceApp.Application.Features.Order.Queries.GetOrders;

public class GetOrdersQueryHandler : IRequestHandler<GetOrdersQuery,List<OrderDto>>
{
    private readonly IOrderRepository _orderRepository;
    private readonly IMapper _mapper;

    public GetOrdersQueryHandler(IMapper mapper, IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
        _mapper = mapper;
    }
    
    public async Task<List<OrderDto>> Handle(GetOrdersQuery request, CancellationToken cancellationToken)
    {
        var orders = await _orderRepository.GetAllAsync();

        return _mapper.Map<List<OrderDto>>(orders);
    }
}