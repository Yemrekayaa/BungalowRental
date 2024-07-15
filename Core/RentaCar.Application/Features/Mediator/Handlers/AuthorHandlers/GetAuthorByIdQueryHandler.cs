using MediatR;
using RentaCar.Application.Features.Mediator.Queries.AuthorQueries;
using RentaCar.Application.Features.Mediator.Results.AuthorResults;
using RentaCar.Application.Interfaces;
using RentaCar.Domain.Entities;

namespace RentaCar.Application.Features.Mediator.Handlers.AuthorHandlers
{
    public class GetAuthorByIdQueryHandler : IRequestHandler<GetAuthorByIdQuery, GetAuthorByIdQueryResult>
    {
        private readonly IRepository<Author> _repository;

        public GetAuthorByIdQueryHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public async Task<GetAuthorByIdQueryResult> Handle(GetAuthorByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetAuthorByIdQueryResult{
                Id = value.Id,
                Name = value.Name,
                Description = value.Description,
                ImageUrl = value.ImageUrl
            };
        }
    }
}