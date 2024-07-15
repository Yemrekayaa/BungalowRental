using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentaCar.Application.Features.Mediator.Commands.AuthorCommands;
using RentaCar.Application.Features.Mediator.Queries.AuthorQueries;

namespace RentaCar.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ListAuthor(){
            var values = await _mediator.Send(new GetAuthorQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuthor(int id){
            var value = await _mediator.Send(new GetAuthorByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAuthor(CreateAuthorCommand command){
            await _mediator.Send(command);
            return Ok("Created");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAuthor(UpdateAuthorCommand command){
            await _mediator.Send(command);
            return Ok("Updated");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveAuthor(RemoveAuthorCommand command){
            await _mediator.Send(command);
            return Ok("Removed");
        }
    }
}