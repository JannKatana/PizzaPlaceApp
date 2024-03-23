namespace PizzaPlaceApp.Application.Contracts.Services;

public interface IFileParsingService
{
    Task<List<object>> ParseAsync(Stream data, Type type);
}