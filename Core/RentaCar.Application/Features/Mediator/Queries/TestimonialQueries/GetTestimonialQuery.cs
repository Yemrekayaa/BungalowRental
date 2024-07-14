using MediatR;
using RentaCar.Application.Features.Mediator.Results.TestimonialResults;

namespace RentaCar.Application.Features.Mediator.Queries.TestimonialQueries
{
    public class GetTestimonialQuery: IRequest<List<GetTestimonialQueryResult>>
    {
        
    }
}