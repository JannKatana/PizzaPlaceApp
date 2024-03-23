using PizzaPlaceApp.Application.Features.Order.Queries.GetOrders;

using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace PizzaPlaceApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        // GET: api/order
        [HttpGet]
        public async Task<ActionResult<OrderDto>> Get()
        {
            var orders = await _mediator.Send(new GetOrdersQuery());
            return Ok(orders);
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