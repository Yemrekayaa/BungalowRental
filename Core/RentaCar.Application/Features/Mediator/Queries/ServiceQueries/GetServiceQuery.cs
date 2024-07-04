
using MediatR;
using RentaCar.Application.Features.Mediator.Results.ServiceResults;

namespace RentaCar.Application.Features.Mediator.Queries.ServiceQueries
{
    public class GetServiceQuery: IRequest<List<GetServiceQueryResult>>
    {
        
    }
}