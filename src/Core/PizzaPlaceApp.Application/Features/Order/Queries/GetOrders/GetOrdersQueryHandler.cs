using PizzaPlaceApp.Application.Contracts.Persistence;

using AutoMapper;
using MediatR;

namespace PizzaPlaceApp.Application.Features.Order.Queries.GetOrders;

public class GetOrderQueryHandler : IRequestHandler<GetOrdersQuery,List<OrderDto>>
{
    private readonly IOrderRepository _orderRepository;
    private readonly IMapper _mapper;

    public GetOrderQueryHandler(IOrderRepository orderRepository, IMapper mapper)
    {
        _orderRepository = orderRepository;
        _mapper = mapper;
    }
    
    public async Task<List<OrderDto>> Handle(GetOrdersQuery request, CancellationToken cancellationToken)
    {
        var Order = await _orderRepository.GetOrdersWithDetails();

        return _mapper.Map<List<OrderDto>>(Order);
    }
}