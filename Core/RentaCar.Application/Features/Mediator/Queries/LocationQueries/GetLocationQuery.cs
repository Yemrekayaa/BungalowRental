using MediatR;
using RentaCar.Application.Features.Mediator.Results.LocationResults;

namespace RentaCar.Application.Features.Mediator.Queries.LocationQueries
{
    public class GetLocationQuery: IRequest<List<GetLocationQueryResult>>
    {
        
    }
}