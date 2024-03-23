using PizzaPlaceApp.Application.Contracts.Services;
using PizzaPlaceApp.Application.Contracts.Persistence;
using AutoMapper;
using MediatR;

namespace PizzaPlaceApp.Application.Features.Import.Commands.ImportOrders;

public class ImportOrdersCommandHandler : IRequestHandler<ImportOrdersCommand, Unit>
{
    private readonly IMapper _mapper;
    private readonly IFileParsingService _fileParsingService;
    private readonly IOrderRepository _orderRepository;

    public ImportOrdersCommandHandler(IMapper mapper, IFileParsingService fileParsingService, IOrderRepository orderRepository)
    {
        _mapper = mapper;
        _fileParsingService = fileParsingService;
        _orderRepository = orderRepository;
    }

    public async Task<Unit> Handle(ImportOrdersCommand request, CancellationToken cancellationToken)
    {
        if (request?.Data != null)
        {
            var records = await _fileParsingService.ParseAsync(request.Data, typeof(ImportOrdersDto));
            if (records is not null)
            {
                var orders = _mapper.Map<List<PizzaPlaceApp.Domain.Order>>(records);
                await _orderRepository.CreateRangeAsync(orders);
            }
            else
            {
                throw new Exception("Failed to parse the file.");
            }

        }

        return Unit.Value;
    }
}