using RentaCar.Application.Features.CQRS.Queries.CategoryQueries;
using RentaCar.Application.Features.CQRS.Results.CategoryResults;
using RentaCar.Application.Interfaces;
using RentaCar.Domain.Entities;

namespace RentaCar.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly IRepository<Category> _repository;
        public GetCategoryByIdQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery query){
            var value = await _repository.GetByIdAsync(query.Id);
            return new GetCategoryByIdQueryResult{
                Id = value.Id,
                Name = value.Name
            };
        }
    }
}