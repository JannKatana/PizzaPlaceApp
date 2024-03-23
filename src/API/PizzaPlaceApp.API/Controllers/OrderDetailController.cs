using PizzaPlaceApp.Application.Features.OrderDetail.Queries.GetOrderDetails;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace PizzaPlaceApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderDetailController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderDetailController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/order
        [HttpGet]
        public async Task<ActionResult<OrderDetailDto>> Get()
        {
            var orderDetails = await _mediator.Send(new GetOrderDetailsQuery());
            return Ok(orderDetails);
        }

        // GET: api/order/{id}
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            // TODO: Implement logic to retrieve order by ID
            return Ok($"Get order with ID: {id}");
        }
    }
}