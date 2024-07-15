using System.Dynamic;
using Microsoft.EntityFrameworkCore;
using RentaCar.Application.Interfaces.CarInterfaces;
using RentaCar.Domain.Entities;
using RentaCar.Persistence.Context;

namespace RentaCar.Persistence.Repositories.CarRepositories
{
    public class CarRepository : ICarRepository
    {
        private readonly RentaCarContext _context;

        public CarRepository(RentaCarContext context)
        {
            _context = context;

        }

        public async Task<List<Car>> GetCarListWithBrand()
        {
            var values = await _context.Cars.Include(x => x.Brand).ToListAsync();
            return values;
        }

        public async Task<List<Car>> GetLast5CarWithBrand()
        {
            var values = await _context.Cars.Include(x => x.Brand).OrderByDescending(x => x.Id).Take(5).ToListAsync();
            return values;
        }
    }
}