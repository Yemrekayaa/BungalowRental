
using MediatR;
using RentaCar.Application.Features.Mediator.Results;

namespace RentaCar.Application.Features.Mediator.Queries.FeatureQueries
{
    public class GetFeatureByIdQuery: IRequest<GetFeatureByIdQueryResult>
    {
        public int Id { get; set; }

        public GetFeatureByIdQuery(int id)
        {
            Id = id;
        }
    }
}