using RentaCar.Application.Features.CQRS.Queries.BrandQueries;
using RentaCar.Application.Features.CQRS.Results.BrandResults;
using RentaCar.Application.Interfaces;
using RentaCar.Domain.Entities;

namespace RentaCar.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandByIdQueryHandler
    {
        private readonly IRepository<Brand> _repository;

        public GetBrandByIdQueryHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }

        public async Task<GetBrandByIdQueryResult> Handle(GetBrandByIdQuery query){
            var result = await _repository.GetByIdAsync(query.Id);
            return new GetBrandByIdQueryResult{
                Id = result.Id,
                Name = result.Name
            };
        }
    }
}