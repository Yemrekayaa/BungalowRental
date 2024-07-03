using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentaCar.Application.Features.Mediator.Commands.LocationCommands;
using RentaCar.Application.Features.Mediator.Queries.LocationQueries;

namespace RentaCar.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LocationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ListLocation(){
            var values = await _mediator.Send(new GetLocationQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetLocation(int id){
            var value = await _mediator.Send(new GetLocationByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateLocation(CreateLocationCommand command){
            await _mediator.Send(command);
            return Ok("Created");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateLocation(UpdateLocationCommand command){
            await _mediator.Send(command);
            return Ok("Updated");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveLocation(RemoveLocationCommand command){
            await _mediator.Send(command);
            return Ok("Removed");
        }
    }
}