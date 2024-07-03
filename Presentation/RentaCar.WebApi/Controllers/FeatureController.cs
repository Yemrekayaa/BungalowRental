using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentaCar.Application.Features.Mediator.Commands.FeatureCommands;
using RentaCar.Application.Features.Mediator.Queries.FeatureQueries;

namespace RentaCar.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FeatureController: ControllerBase
    {
        private readonly IMediator _mediator;

        public FeatureController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> FeatureList(){
            var values = await _mediator.Send(new GetFeatureQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> FeatureGetById(int id){
            var value = await _mediator.Send(new GetFeatureByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateFeature(CreateFeatureCommand command){
            await _mediator.Send(command);
            return Ok("Created");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFeature(UpdateFeatureCommand command){
            await _mediator.Send(command);
            return Ok("Updated");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveFeature(RemoveFeatureCommand command){
            await _mediator.Send(command);
            return Ok("Removed");
        }
    }
}