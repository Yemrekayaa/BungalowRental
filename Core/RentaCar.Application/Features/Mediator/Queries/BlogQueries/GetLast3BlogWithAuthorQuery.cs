using MediatR;
using RentaCar.Application.Features.Mediator.Results.BlogResults;

namespace RentaCar.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetLast3BlogWithAuthorQuery: IRequest<List<GetLast3BlogWithAuthorQueryResult>>
    {
        
    }
}