using PizzaPlaceApp.Application.Features.Import.Commands.ImportOrders;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PizzaPlaceApp.Application.Features.Import.Commands.ImportOrderDetails;

namespace PizzaPlaceApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImportController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ImportController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("Orders")]
        public async Task<ActionResult> ImportOrdersCsv(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest(new { Message = "No file uploaded." });
            }

            // Check if the file is a CSV file
            if (Path.GetExtension(file.FileName).ToLower() != ".csv")
            {
                return BadRequest(new { Message = "Invalid file format. Only CSV files are allowed." });
            }

            await _mediator.Send(new ImportOrdersCommand { Data = file.OpenReadStream() });

            return Ok(new { Message = "CSV file uploaded and processed successfully." });
        }

        [HttpPost("OrderDetails")]
        public async Task<ActionResult> ImportOrderDetailsCsv(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest(new { Message = "No file uploaded." });
            }

            // Check if the file is a CSV file
            if (Path.GetExtension(file.FileName).ToLower() != ".csv")
            {
                return BadRequest(new { Message = "Invalid file format. Only CSV files are allowed." });
            }

            await _mediator.Send(new ImportOrderDetailsCommand { Data = file.OpenReadStream() });

            return Ok(new { Message = "CSV file uploaded and processed successfully." });
        }
    }
}