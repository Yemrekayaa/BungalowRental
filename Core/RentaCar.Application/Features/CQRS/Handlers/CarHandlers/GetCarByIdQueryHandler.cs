using RentaCar.Application.Features.CQRS.Queries.CarQueries;
using RentaCar.Application.Features.CQRS.Results.CarResults;
using RentaCar.Application.Interfaces;
using RentaCar.Domain.Entities;

namespace RentaCar.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarByIdQueryHandler
    {
        private readonly IRepository<Car> _repository;

        public GetCarByIdQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query){
            var value = await _repository.GetByIdAsync(query.Id);
            return new GetCarByIdQueryResult{
                Id = value.Id,
                BrandId = value.BrandId,
                Model = value.Model,
                CoverImageUrl = value.CoverImageUrl,
                Km = value.Km,
                Transmission = value.Transmission,
                Seat = value.Seat,
                Luggage = value.Luggage,
                Fuel = value.Fuel,
                BigImageUrl = value.BigImageUrl
            };
        } 
    }
}