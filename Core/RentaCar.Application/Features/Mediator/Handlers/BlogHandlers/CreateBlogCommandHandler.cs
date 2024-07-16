using MediatR;
using RentaCar.Application.Features.Mediator.Commands.BlogCommands;
using RentaCar.Application.Interfaces;
using RentaCar.Domain.Entities;

namespace RentaCar.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand>
    {
        private readonly IRepository<Blog> _repository;

        public CreateBlogCommandHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {
            var value = new Blog{
                Title = request.Title,
                CategoryId = request.CategoryId,
                CreatedDate = DateTime.Now,
                AuthorId = request.AuthorId,
                CoverImageUrl = request.CoverImageUrl
            };
            await _repository.CreateAsync(value);
        }
    }
}