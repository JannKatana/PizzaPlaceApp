using PizzaPlaceApp.Domain;
using PizzaPlaceApp.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Shouldly;

namespace PizzaPlaceApp.Persistence.IntegrationTests;

public class PizzaPlaceDatabaseContextTests
{
    private readonly PizzaPlaceDatabaseContext _pizzaPlaceDatabaseContext;

    public PizzaPlaceDatabaseContextTests()
    {
        var dbOptions = new DbContextOptionsBuilder<PizzaPlaceDatabaseContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

        _pizzaPlaceDatabaseContext = new PizzaPlaceDatabaseContext(dbOptions);
    }

    [Fact]
    public async void Save_SetDateCreatedValue()
    {
        // Arrange
        var order = new Order
        {
            Id = 1,
            Date = DateOnly.Parse("1/1/2015"),
            Time = TimeOnly.Parse("11:38:36")
        };

        // Act
        await _pizzaPlaceDatabaseContext.Orders.AddAsync(order);
        await _pizzaPlaceDatabaseContext.SaveChangesAsync();

        // Assert
        order.DateCreated.ShouldNotBeNull();
    }

    [Fact]
    public async void Save_SetDateModifiedValue()
    {
        // Arrange
        var order = new Order
        {
            Id = 1,
            Date = DateOnly.Parse("1/1/2016"),
            Time = TimeOnly.Parse("11:38:40")
        };

        // Act
        await _pizzaPlaceDatabaseContext.Orders.AddAsync(order);
        await _pizzaPlaceDatabaseContext.SaveChangesAsync();

        // Assert
        order.DateModified.ShouldNotBeNull();
    }
}