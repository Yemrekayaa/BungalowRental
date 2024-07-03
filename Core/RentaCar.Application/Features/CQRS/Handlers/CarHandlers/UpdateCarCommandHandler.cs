using RentaCar.Application.Features.CQRS.Commands.CarCommands;
using RentaCar.Application.Interfaces;
using RentaCar.Domain.Entities;

namespace RentaCar.Application.Features.CQRS.Handlers.CarHandlers
{
    public class UpdateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public UpdateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCarCommand command){
            var value = await _repository.GetByIdAsync(command.Id);
            value.Id = command.Id;
            value.BrandId = command.BrandId;
            value.Model = command.Model;
            value.CoverImageUrl = command.CoverImageUrl;
            value.Km = command.Km;
            value.Transmission = command.Transmission;
            value.Seat = command.Seat;
            value.Luggage = command.Luggage;
            value.Fuel = command.Fuel;
            value.BigImageUrl = command.BigImageUrl;
            await _repository.UpdateAsync(value);
        }
    }
}