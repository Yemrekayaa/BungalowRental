using RentaCar.Application.Features.CQRS.Results.CarResults;
using RentaCar.Application.Interfaces.CarInterfaces;

namespace RentaCar.Application.Features.CQRS.Queries.CarQueries
{
    public class GetLast5CarWithBrandQueryHandler
    {
        private readonly ICarRepository _carRepository;

        public GetLast5CarWithBrandQueryHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task<List<GetLast5CarWithBrandQueryResult>> Handle(){
            var values = await _carRepository.GetLast5CarWithBrand();
            return values.Select(x => new GetLast5CarWithBrandQueryResult{
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