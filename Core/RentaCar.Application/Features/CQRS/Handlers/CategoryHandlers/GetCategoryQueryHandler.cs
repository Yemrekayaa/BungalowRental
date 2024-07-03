using RentaCar.Application.Features.CQRS.Results.CategoryResults;
using RentaCar.Application.Interfaces;
using RentaCar.Domain.Entities;

namespace RentaCar.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler
    {
        private readonly IRepository<Category> _repository;

        public GetCategoryQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCategoryQueryResult>> Handle(){
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCategoryQueryResult {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }
    }
}