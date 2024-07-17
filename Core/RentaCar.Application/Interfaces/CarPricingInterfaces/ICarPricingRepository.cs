using RentaCar.Domain.Entities;

namespace RentaCar.Application.Interfaces.CarPricingInterfaces
{
    public interface ICarPricingRepository
    {
        Task<List<CarPricing>> GetCarPricingWithCAR();
    }
}