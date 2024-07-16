
using MediatR;

namespace RentaCar.Application.Features.Mediator.Commands.BlogCommands
{
    public class CreateBlogCommand: IRequest
    {
        public String Title { get; set; }
        public int AuthorId { get; set; }
        public String CoverImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CategoryId { get; set; }
    }
}