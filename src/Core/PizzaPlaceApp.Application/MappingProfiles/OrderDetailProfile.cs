using PizzaPlaceApp.Application.Features.OrderDetail.Queries.GetOrderDetails;
using PizzaPlaceApp.Application.Features.Import.Commands.ImportOrderDetails;
using PizzaPlaceApp.Domain;
using AutoMapper;

namespace PizzaPlaceApp.Application.MappingProfiles;

public class OrderDetailProfile : Profile
{
    public OrderDetailProfile()
    {
        CreateMap<OrderDetailDto, OrderDetail>().ReverseMap();
        CreateMap<OrderDetail, ImportOrderDetailsDto>()
            .ForMember(dto => dto.order_id, opt => opt.MapFrom(order => order.OrderId))
            .ForMember(dto => dto.pizza_id, opt => opt.MapFrom(order => order.PizzaId))
            .ForMember(dto => dto.order_details_id, opt => opt.MapFrom(order => order.OrderDetailId))
            .ReverseMap();
        
    }
}