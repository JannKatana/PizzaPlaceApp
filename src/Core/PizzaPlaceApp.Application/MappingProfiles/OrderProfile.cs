using AutoMapper;
using PizzaPlaceApp.Application.Features.Import.Commands.ImportOrders;
using PizzaPlaceApp.Application.Features.Order.Queries.GetOrders;
using PizzaPlaceApp.Domain;

namespace PizzaPlaceApp.Application.MappingProfiles;

public class OrderProfile : Profile
{
    public OrderProfile()
    {
        CreateMap<OrderDto, Order>().ReverseMap();
        CreateMap<Order, ImportOrdersDto>()
            .ForMember(dto => dto.order_id, opt => opt.MapFrom(order => order.OrderId))
            .ReverseMap();
    }
}