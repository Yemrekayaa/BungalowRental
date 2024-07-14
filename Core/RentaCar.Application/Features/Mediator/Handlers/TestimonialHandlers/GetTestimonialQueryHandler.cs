using MediatR;
using RentaCar.Application.Features.Mediator.Queries.TestimonialQueries;
using RentaCar.Application.Features.Mediator.Results.TestimonialResults;
using RentaCar.Application.Interfaces;
using RentaCar.Domain.Entities;

namespace RentaCar.Application.Features.Mediator.Handlers.TestimonialHandlers
{
    public class GetTestimonialQueryHandler : IRequestHandler<GetTestimonialQuery, List<GetTestimonialQueryResult>>
    {
        private readonly IRepository<Testimonial> _repository;

        public GetTestimonialQueryHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTestimonialQueryResult>> Handle(GetTestimonialQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetTestimonialQueryResult{
                Id = x.Id,
                Title = x.Title,
                Comment = x.Comment,
                Name = x.Name,
                ImageUrl = x.ImageUrl
            }).ToList();
        }
    }
}