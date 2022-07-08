using DemoAcl.Application.Mediator.Queries;
using DemoAcl.Infrastructure.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DemoAcl.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopifyController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ShopifyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("product/get")]
        public async Task<IActionResult> GetProduct([FromQuery] string productId) 
        {
            ShopifyProductDto product = await _mediator.Send(new GetShopifyProductQuery(productId));

            if (product is null)
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }

            return StatusCode(StatusCodes.Status200OK, product);
        }
    }
}
