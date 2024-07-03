using MediatR;
using RentaCar.Application.Features.Mediator.Results;

namespace RentaCar.Application.Features.Mediator.Queries.FeatureQueries
{
    public class GetFeatureQuery: IRequest<List<GetFeatureQueryResult>>
    {
        
    }
}