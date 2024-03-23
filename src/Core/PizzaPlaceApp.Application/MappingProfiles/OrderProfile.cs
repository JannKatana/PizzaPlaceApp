using AutoMapper;

using PizzaPlaceApp.Application.Features.Order.Queries.GetOrders;
using PizzaPlaceApp.Domain;

namespace PizzaPlaceApp.Application.MappingProfiles;

public class LeaveTypeProfile : Profile
{
    public LeaveTypeProfile()
    {
        CreateMap<OrderDto, Order>().ReverseMap();
        // CreateMap<OrderDetailDto, OrderDetail>();
    }
}