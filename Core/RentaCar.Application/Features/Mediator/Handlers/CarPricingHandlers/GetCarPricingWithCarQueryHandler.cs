using MediatR;
using RentaCar.Application.Features.Mediator.Queries.CarPricingQueries;
using RentaCar.Application.Features.Mediator.Results.CarPricingResults;
using RentaCar.Application.Interfaces.CarPricingInterfaces;

namespace RentaCar.Application.Features.Mediator.Handlers.CarPricingHandlers
{
    public class GetCarPricingWithCarQueryHandler: IRequestHandler<GetCarPricingWithCarQuery,List<GetCarPricingWithCarQueryResult>>
    {
        private readonly ICarPricingRepository _repository;

        public GetCarPricingWithCarQueryHandler(ICarPricingRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCarPricingWithCarQueryResult>> Handle(GetCarPricingWithCarQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetCarPricingWithCAR();
            return values.Select(x => new GetCarPricingWithCarQueryResult{
                Id = x.Id,
                Brand = x.Car.Brand.Name,
                Model = x.Car.Model,
                Amount = x.Amount,
                CoverImageUrl = x.Car.CoverImageUrl
            }).ToList();
        }
    }
}