using MediatR;
using RentaCar.Application.Features.Mediator.Results.CarPricingResults;

namespace RentaCar.Application.Features.Mediator.Queries.CarPricingQueries
{
    public class GetCarPricingWithCarQuery: IRequest<List<GetCarPricingWithCarQueryResult>>
    {
        
    }
}