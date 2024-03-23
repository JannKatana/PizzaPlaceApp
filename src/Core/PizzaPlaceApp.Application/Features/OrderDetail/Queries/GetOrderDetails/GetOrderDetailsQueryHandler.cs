using PizzaPlaceApp.Application.Contracts.Persistence;

using AutoMapper;
using MediatR;

namespace PizzaPlaceApp.Application.Features.OrderDetail.Queries.GetOrderDetails;

public class GetOrderDetailsQueryHandler : IRequestHandler<GetOrderDetailsQuery,List<OrderDetailDto>>
{
    private readonly IOrderDetailRepository _orderDetailRepository;
    private readonly IMapper _mapper;

    public GetOrderDetailsQueryHandler(IOrderDetailRepository orderDetailsRepository, IMapper mapper)
    {
        _orderDetailRepository = orderDetailsRepository;
        _mapper = mapper;
    }
    
    public async Task<List<OrderDetailDto>> Handle(GetOrderDetailsQuery request, CancellationToken cancellationToken)
    {
        var orderDetailsrder = await _orderDetailRepository.GetAllAsync();

        return _mapper.Map<List<OrderDetailDto>>(orderDetailsrder);
    }
}