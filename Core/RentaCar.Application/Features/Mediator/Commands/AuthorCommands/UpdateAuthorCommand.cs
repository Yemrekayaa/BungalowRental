using MediatR;

namespace RentaCar.Application.Features.Mediator.Commands.AuthorCommands
{
    public class UpdateAuthorCommand: IRequest
    {
        
        public int Id { get; set; }
        public String Name { get; set; }
        public String ImageUrl { get; set; }
        public String Description { get; set; }
    }
}