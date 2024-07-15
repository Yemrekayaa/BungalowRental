using MediatR;
using RentaCar.Application.Features.Mediator.Results.AuthorResults;

namespace RentaCar.Application.Features.Mediator.Queries.AuthorQueries
{
    public class GetAuthorByIdQuery: IRequest<GetAuthorByIdQueryResult>
    {
        public int Id { get; set; }

        public GetAuthorByIdQuery(int id)
        {
            Id = id;
        }
    }
}