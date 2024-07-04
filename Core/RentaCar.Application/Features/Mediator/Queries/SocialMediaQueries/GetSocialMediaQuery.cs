
using MediatR;
using RentaCar.Application.Features.Mediator.Results.SocialMediaResults;

namespace RentaCar.Application.Features.Mediator.Queries.SocialMediaQueries
{
    public class GetSocialMediaQuery: IRequest<List<GetSocialMediaQueryResult>>
    {
        
    }
}