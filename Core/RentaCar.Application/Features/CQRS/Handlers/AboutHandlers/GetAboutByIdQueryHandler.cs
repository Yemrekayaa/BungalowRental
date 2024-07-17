using RentaCar.Application.Features.CQRS.Queries.AboutQueries;
using RentaCar.Application.Features.CQRS.Results.AboutResults;
using RentaCar.Application.Interfaces;
using RentaCar.Domain.Entities;

namespace RentaCar.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class GetAboutByIdQueryHandler
    {
        private readonly IRepository<About> _repository;

        public GetAboutByIdQueryHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task<GetAboutByIdQueryResult> Handle(GetAboutByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.Id);
            return new GetAboutByIdQueryResult
            {
                Id = value.Id,
                Description = value.Description,
                Title = value.Title,
                ImageUrl = value.ImageUrl
            };
        }
    }
}