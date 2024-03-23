using AutoMapper;
using PizzaPlaceApp.Application.Contracts.Logging;
using PizzaPlaceApp.Application.Contracts.Persistence;
using PizzaPlaceApp.Application.Features.Order.Queries.GetOrders;
using PizzaPlaceApp.Application.MappingProfiles;
using PizzaPlaceApp.Application.UnitTests.Mocks;
using Moq;
using Shouldly;

namespace PizzaPlaceApp.Application.UnitTests.Features.Orders.Queries;

public class GetOrderListQueryHandlerTests
{
    private readonly Mock<IOrderRepository> _mockRepo;
    private readonly IMapper _mapper;

    public GetOrderListQueryHandlerTests()
    {
        _mockRepo = MockOrderRepository.GetMockOrderRepository();
        var mapperConfig = new MapperConfiguration(c => { c.AddProfile<OrderProfile>(); });

        _mapper = mapperConfig.CreateMapper();
    }

    [Fact]
    public async Task GetOrderListTest()
    {
        var handler = new GetOrdersQueryHandler(_mapper, _mockRepo.Object);

        var result = await handler.Handle(new GetOrdersQuery(), CancellationToken.None);

        result.ShouldBeOfType<List<OrderDto>>();
        result.Count.ShouldBe(3);
    }
}