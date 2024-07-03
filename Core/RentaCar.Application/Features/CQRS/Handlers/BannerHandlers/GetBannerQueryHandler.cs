using RentaCar.Application.Features.CQRS.Results.BannerResults;
using RentaCar.Application.Interfaces;
using RentaCar.Domain.Entities;

namespace RentaCar.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class GetBannerQueryHandler
    {
        private readonly IRepository<Banner> _repository;

        public GetBannerQueryHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBannerQueryResult>> Handle(){
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetBannerQueryResult{
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                VideoDescription = x.VideoDescription,
                VideoUrl = x.VideoUrl,
            }).ToList();
        }
    }
}
