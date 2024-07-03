using RentaCar.Application.Features.CQRS.Commands.CategoryCommands;
using RentaCar.Application.Interfaces;
using RentaCar.Domain.Entities;

namespace RentaCar.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class UpdateCategoryCommandHandler
    {
        private readonly IRepository<Category> _repository;

        public UpdateCategoryCommandHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCategoryCommand command){
            var value = await _repository.GetByIdAsync(command.Id);
            value.Name = command.Name;
            await _repository.UpdateAsync(value);
        }
    }
}