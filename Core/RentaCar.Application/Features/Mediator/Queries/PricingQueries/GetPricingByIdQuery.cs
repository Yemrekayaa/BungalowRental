using MediatR;
using RentaCar.Application.Features.Mediator.Results.PricingResults;

namespace RentaCar.Application.Features.Mediator.Queries.PricingQueries
{
    public class GetPricingByIdQuery: IRequest<GetPricingByIdQueryResult>
    {
        public int Id { get; set; }

        public GetPricingByIdQuery(int id)
        {
            Id = id;
        }
    }
}