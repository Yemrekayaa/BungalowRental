using MediatR;
using RentaCar.Application.Features.Mediator.Results.BlogResults;

namespace RentaCar.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetBlogWithAuthorQuery : IRequest<List<GetBlogWithAuthorQueryResult>>
    {

    }
}