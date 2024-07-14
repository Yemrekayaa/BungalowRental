using MediatR;
using RentaCar.Application.Features.Mediator.Queries.TestimonialQueries;
using RentaCar.Application.Features.Mediator.Results.TestimonialResults;
using RentaCar.Application.Interfaces;
using RentaCar.Domain.Entities;

namespace RentaCar.Application.Features.Mediator.Handlers.TestimonialHandlers
{
    public class GetTestimonialByIdQueryHandler : IRequestHandler<GetTestimonialByIdQuery, GetTestimonialByIdQueryResult>
    {
        private readonly IRepository<Testimonial> _repository;

        public GetTestimonialByIdQueryHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task<GetTestimonialByIdQueryResult> Handle(GetTestimonialByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetTestimonialByIdQueryResult{
                Id = value.Id,
                Name = value.Name,
                Title = value.Title,
                ImageUrl = value.ImageUrl,
                Comment = value.Comment
            };
        }
    }
}