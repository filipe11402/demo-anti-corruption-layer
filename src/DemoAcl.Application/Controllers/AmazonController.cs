using DemoAcl.Application.Mediator.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DemoAcl.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmazonController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AmazonController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("product/get")]
        public async Task<IActionResult> GetProduct([FromQuery] string productId) 
        {
            var product = await _mediator.Send(new GetAmazonProductQuery(productId));

            if (product.IsError) 
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }

            return StatusCode(StatusCodes.Status200OK, product.Value);
        }
    }
}
