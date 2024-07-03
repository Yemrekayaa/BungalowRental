
using RentaCar.Application.Features.CQRS.Results.BrandResults;
using RentaCar.Application.Interfaces;
using RentaCar.Domain.Entities;

namespace RentaCar.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandQueryHandler
    {
        private readonly IRepository<Brand> _repository;

        public GetBrandQueryHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetBrandQueryResult>> Handle(){
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetBrandQueryResult{
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }
    }
}