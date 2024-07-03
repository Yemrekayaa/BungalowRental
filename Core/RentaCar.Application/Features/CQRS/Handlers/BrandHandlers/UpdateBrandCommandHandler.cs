using RentaCar.Application.Features.CQRS.Commands.BrandCommands;
using RentaCar.Application.Interfaces;
using RentaCar.Domain.Entities;

namespace RentaCar.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class UpdateBrandCommandHandler
    {
        private readonly IRepository<Brand> _repository;

        public UpdateBrandCommandHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBrandCommand command){
            var value = await _repository.GetByIdAsync(command.Id);
            value.Name = command.Name;
            await _repository.UpdateAsync(value);
        }
    }
}