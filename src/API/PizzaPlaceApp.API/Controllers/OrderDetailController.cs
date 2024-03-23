using Microsoft.AspNetCore.Mvc;

namespace PizzaPlaceApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderDetailController : ControllerBase
    {
        // GET: api/order
        [HttpGet]
        public IActionResult Get()
        {
            // TODO: Implement logic to retrieve all orders
            return Ok("Get all orders");
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