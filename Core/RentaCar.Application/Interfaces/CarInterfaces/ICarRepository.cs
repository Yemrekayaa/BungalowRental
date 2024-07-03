using RentaCar.Domain.Entities;

namespace RentaCar.Application.Interfaces.CarInterfaces
{
    public interface ICarRepository
    {
        Task<List<Car>> GetCarListWithBrand();
    }
}