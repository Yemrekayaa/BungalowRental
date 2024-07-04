using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentaCar.Application.Features.Mediator.Commands.ServiceCommands;
using RentaCar.Application.Features.Mediator.Queries.ServiceQueries;

namespace RentaCar.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServiceController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ServiceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ListService(){
            var values = await _mediator.Send(new GetServiceQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetService(int id){
            var value = await _mediator.Send(new GetServiceByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateService(CreateServiceCommand command){
            await _mediator.Send(command);
            return Ok("Created");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateService(UpdateServiceCommand command){
            await _mediator.Send(command);
            return Ok("Updated");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveService(RemoveServiceCommand command){
            await _mediator.Send(command);
            return Ok("Removed");
        }
    }
}