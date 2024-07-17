using Microsoft.EntityFrameworkCore;
using RentaCar.Application.Interfaces.CarPricingInterfaces;
using RentaCar.Domain.Entities;
using RentaCar.Persistence.Context;

namespace RentaCar.Persistence.Repositories.CarPricingRepositories
{
    public class CarPricingRepository : ICarPricingRepository
    {
        private readonly RentaCarContext _context;

        public CarPricingRepository(RentaCarContext context)
        {
            _context = context;
        }

        public async Task<List<CarPricing>> GetCarPricingWithCAR()
        {
            var values = await _context.CarPricings
            .Include(x => x.Car)
            .ThenInclude(x => x.Brand)
            .Include(x => x.Pricing)
            .Where(x => x.PricingID == 1)
            .ToListAsync();
            return values;
        }
    }
}