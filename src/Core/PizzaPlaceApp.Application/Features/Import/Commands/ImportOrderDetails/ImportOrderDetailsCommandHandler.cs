using PizzaPlaceApp.Application.Contracts.Services;
using PizzaPlaceApp.Application.Contracts.Persistence;
using AutoMapper;
using MediatR;

namespace PizzaPlaceApp.Application.Features.Import.Commands.ImportOrderDetails;

public class ImportOrderDetailsCommandHandler : IRequestHandler<ImportOrderDetailsCommand, Unit>
{
    private readonly IMapper _mapper;
    private readonly IFileParsingService _fileParsingService;
    private readonly IOrderDetailRepository _orderDetailRepository;

    public ImportOrderDetailsCommandHandler(IMapper mapper, IFileParsingService fileParsingService, IOrderDetailRepository orderRepository)
    {
        _mapper = mapper;
        _fileParsingService = fileParsingService;
        _orderDetailRepository = orderRepository;
    }

    public async Task<Unit> Handle(ImportOrderDetailsCommand request, CancellationToken cancellationToken)
    {
        if (request?.Data != null)
        {
            var records = await _fileParsingService.ParseAsync(request.Data, typeof(ImportOrderDetailsDto));
            if (records is not null)
            {
                var orderDetails = _mapper.Map<List<PizzaPlaceApp.Domain.OrderDetail>>(records);
                await _orderDetailRepository.CreateRangeAsync(orderDetails);
            }
            else
            {
                throw new Exception("Failed to parse the file.");
            }

        }

        return Unit.Value;
    }
}