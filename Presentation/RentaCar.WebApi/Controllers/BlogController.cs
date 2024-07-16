using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentaCar.Application.Features.Mediator.Commands.BlogCommands;
using RentaCar.Application.Features.Mediator.Queries.BlogQueries;

namespace RentaCar.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BlogController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ListBlog(){
            var values = await _mediator.Send(new GetBlogQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlog(int id){
            var value = await _mediator.Send(new GetBlogByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateBlogCommand command){
            await _mediator.Send(command);
            return Ok("Created");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBlog(UpdateBlogCommand command){
            await _mediator.Send(command);
            return Ok("Updated");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveBlog(RemoveBlogCommand command){
            await _mediator.Send(command);
            return Ok("Removed");
        }
        [HttpGet("GetLast3BlogWithAuthor")]
        public async Task<IActionResult> GetLast3BlogWithAuthor(){
            var values = await _mediator.Send(new GetLast3BlogWithAuthorQuery());
            return Ok(values);
        }
    }
}