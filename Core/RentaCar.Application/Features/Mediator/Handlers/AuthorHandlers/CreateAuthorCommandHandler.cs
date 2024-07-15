using MediatR;
using RentaCar.Application.Features.Mediator.Commands.AuthorCommands;
using RentaCar.Application.Interfaces;
using RentaCar.Domain.Entities;

namespace RentaCar.Application.Features.Mediator.Handlers.AuthorHandlers
{
    public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommand>
    {
        private readonly IRepository<Author> _repository;

        public CreateAuthorCommandHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
        {
            var value = new Author{
                Name = request.Name,
                Description = request.Description,
                ImageUrl = request.ImageUrl
            };
            await _repository.CreateAsync(value);
        }
    }
}