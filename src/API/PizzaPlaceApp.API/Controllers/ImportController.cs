using Microsoft.AspNetCore.Mvc;

namespace PizzaPlaceApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImportController : ControllerBase
    {
        // GET: api/import
        [HttpGet]
        public IActionResult Get()
        {
            // TODO: Implement your logic here
            return Ok("GET request received");
        }

        // POST: api/import
        [HttpPost]
        public IActionResult Post()
        {
            // TODO: Implement your logic here
            return Ok("POST request received");
        }

        // PUT: api/import/{id}
        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {
            // TODO: Implement your logic here
            return Ok($"PUT request received for id: {id}");
        }

        // DELETE: api/import/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // TODO: Implement your logic here
            return Ok($"DELETE request received for id: {id}");
        }
    }
}