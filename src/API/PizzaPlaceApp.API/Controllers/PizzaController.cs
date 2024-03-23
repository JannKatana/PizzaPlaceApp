using Microsoft.AspNetCore.Mvc;

namespace PizzaPlaceApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PizzaController : ControllerBase
    {
        // GET: api/pizza
        [HttpGet]
        public IActionResult Get()
        {
            // TODO: Implement logic to retrieve all pizzas
            return Ok("Get all pizzas");
        }

        // GET: api/pizza/{id}
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            // TODO: Implement logic to retrieve a specific pizza by id
            return Ok($"Get pizza with id {id}");
        }
    }
}