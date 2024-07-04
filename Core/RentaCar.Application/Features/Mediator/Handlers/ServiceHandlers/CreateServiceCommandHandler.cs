
using MediatR;
using RentaCar.Application.Features.Mediator.Commands.ServiceCommands;
using RentaCar.Application.Interfaces;
using RentaCar.Domain.Entities;

namespace RentaCar.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class CreateServiceCommandHandler : IRequestHandler<CreateServiceCommand>
    {
        private readonly IRepository<Service> _repository;

        public CreateServiceCommandHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateServiceCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Service{
                Title = request.Title,
                Description = request.Description,
                IconUrl = request.IconUrl
            });
        }
    }
}