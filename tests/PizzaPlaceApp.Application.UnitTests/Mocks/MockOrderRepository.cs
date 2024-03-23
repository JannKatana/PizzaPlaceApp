using PizzaPlaceApp.Application.Contracts.Persistence;
using PizzaPlaceApp.Domain;
using Moq;

namespace PizzaPlaceApp.Application.UnitTests.Mocks;

public class MockOrderRepository
{
    public static Mock<IOrderRepository> GetMockOrderRepository()
    {
        var order = new List<Order>
        {
            new Order
            {
                 Id = 1,
                Date = DateOnly.Parse("1/1/2015"),
                Time = TimeOnly.Parse("11:38:36")
            },
            new Order
            {
                Id = 2,
                Date = DateOnly.Parse("1/2/2015"),
                Time = TimeOnly.Parse("10:38:36")
            },
            new Order
            {
                Id = 2,
                Date = DateOnly.Parse("1/2/2015"),
                Time = TimeOnly.Parse("12:38:36")
            }
        };

        var mockRepo = new Mock<IOrderRepository>();

        mockRepo.Setup(r => r.GetAllAsync()).ReturnsAsync(order);

        mockRepo.Setup(r => r.CreateAsync(It.IsAny<Order>())).Returns((Order Order) =>
        {
            order.Add(Order);
            return Task.CompletedTask;
        });

        return mockRepo;
    }
}