using RentaCar.Application.Features.CQRS.Results.CarResults;
using RentaCar.Application.Interfaces;
using RentaCar.Application.Interfaces.CarInterfaces;
using RentaCar.Domain.Entities;

namespace RentaCar.Application.Features.CQRS.Queries.CarQueries
{
    public class GetCarWithBrandQueryHandler
    {
        private readonly ICarRepository _carRepository;

        public GetCarWithBrandQueryHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task<List<GetCarWithBrandQueryResult>> Handle(){
            var values = await _carRepository.GetCarListWithBrand();
            return values.Select(x => new GetCarWithBrandQueryResult{
                Id = x.Id,
                BrandId = x.BrandId,
                BrandName = x.Brand.Name,
                Model = x.Model,
                CoverImageUrl = x.CoverImageUrl,
                Km = x.Km,
                Transmission = x.Transmission,
                Seat = x.Seat,
                Luggage = x.Luggage,
                Fuel = x.Fuel,
                BigImageUrl = x.BigImageUrl
            }).ToList();
        }
    }
}