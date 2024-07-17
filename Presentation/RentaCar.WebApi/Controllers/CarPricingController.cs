using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentaCar.Application.Features.Mediator.Queries.CarPricingQueries;

namespace RentaCar.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarPricingController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarPricingController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("CarPricingWithCar")]
        public async Task<IActionResult> GetCarPricingWithCar(){
            var values = await _mediator.Send(new GetCarPricingWithCarQuery());
            return Ok(values);
        }
    }
}