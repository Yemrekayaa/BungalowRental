using MediatR;
using RentaCar.Application.Features.Mediator.Results.ServiceResults;

namespace RentaCar.Application.Features.Mediator.Queries.ServiceQueries
{
    public class GetServiceByIdQuery: IRequest<GetServiceByIdQueryResult>
    {
        public int Id { get; set; }

        public GetServiceByIdQuery(int id)
        {
            Id = id;
        }
    }
}