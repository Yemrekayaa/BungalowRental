using MediatR;
using RentaCar.Application.Features.Mediator.Results.TestimonialResults;

namespace RentaCar.Application.Features.Mediator.Queries.TestimonialQueries
{
    public class GetTestimonialByIdQuery: IRequest<GetTestimonialByIdQueryResult>
    {
        public int Id { get; set; }

        public GetTestimonialByIdQuery(int id)
        {
            Id = id;
        }
    }
}