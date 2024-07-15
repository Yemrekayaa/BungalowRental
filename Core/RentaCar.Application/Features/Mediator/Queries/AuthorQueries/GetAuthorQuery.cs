using MediatR;
using RentaCar.Application.Features.Mediator.Results.AuthorResults;

namespace RentaCar.Application.Features.Mediator.Queries.AuthorQueries
{
    public class GetAuthorQuery: IRequest<List<GetAuthorQueryResult>>
    {
        
    }
}