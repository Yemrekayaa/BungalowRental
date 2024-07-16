
using MediatR;
using RentaCar.Application.Features.Mediator.Results.BlogResults;

namespace RentaCar.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetBlogByIdQuery: IRequest<GetBlogByIdQueryResult>
    {
        public int Id { get; set; }

        public GetBlogByIdQuery(int id)
        {
            Id = id;
        }
    }
}