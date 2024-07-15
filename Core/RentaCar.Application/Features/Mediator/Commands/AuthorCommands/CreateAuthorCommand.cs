
using MediatR;

namespace RentaCar.Application.Features.Mediator.Commands.AuthorCommands
{
    public class CreateAuthorCommand: IRequest
    {
        public String Name { get; set; }
        public String ImageUrl { get; set; }
        public String Description { get; set; }
    }
}