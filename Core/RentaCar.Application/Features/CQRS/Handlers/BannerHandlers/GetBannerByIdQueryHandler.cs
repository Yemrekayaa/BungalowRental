using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RentaCar.Application.Features.CQRS.Queries.BannerQueries;
using RentaCar.Application.Features.CQRS.Results.BannerResults;
using RentaCar.Application.Interfaces;
using RentaCar.Domain.Entities;

namespace RentaCar.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class GetBannerByIdQueryHandler
    {
        private readonly IRepository<Banner> _repository;

        public GetBannerByIdQueryHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task<GetBannerByIdQueryResult> Handle(GetBannerByIdQuery query){
            var value = await _repository.GetByIdAsync(query.Id);
            return new GetBannerByIdQueryResult{
                Id = value.Id,
                Title = value.Title,
                Description = value.Description,
                VideoDescription = value.VideoDescription,
                VideoUrl = value.VideoUrl
            };
        }
    }
}