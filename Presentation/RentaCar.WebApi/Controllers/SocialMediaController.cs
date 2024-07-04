using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentaCar.Application.Features.Mediator.Commands.SocialMediaCommands;
using RentaCar.Application.Features.Mediator.Queries.SocialMediaQueries;

namespace RentaCar.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SocialMediaController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SocialMediaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ListSocialMedia(){
            var values = await _mediator.Send(new GetSocialMediaQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSocialMedia(int id){
            var value = await _mediator.Send(new GetSocialMediaByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateSocialMedia(CreateSocialMediaCommand command){
            await _mediator.Send(command);
            return Ok("Created");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateSocialMedia(UpdateSocialMediaCommand command){
            await _mediator.Send(command);
            return Ok("Updated");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveSocialMedia(RemoveSocialMediaCommand command){
            await _mediator.Send(command);
            return Ok("Removed");
        }
    }
}