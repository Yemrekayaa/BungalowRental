
using MediatR;
using RentaCar.Application.Features.Mediator.Results.PricingResults;

namespace RentaCar.Application.Features.Mediator.Queries.PricingQueries
{
    public class GetPricingQuery: IRequest<List<GetPricingQueryResult>>
    {
        
    }
}