
using MediatR;
using RentaCar.Application.Features.Mediator.Commands.ServiceCommands;
using RentaCar.Application.Interfaces;
using RentaCar.Domain.Entities;

namespace RentaCar.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class UpdateServiceCommandHandler : IRequestHandler<UpdateServiceCommand>
    {
        private readonly IRepository<Service> _repository;

        public UpdateServiceCommandHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateServiceCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            value.Title = request.Title;
            value.Description = request.Description;
            value.IconUrl = request.IconUrl;
            await _repository.UpdateAsync(value);
        }
    }
}