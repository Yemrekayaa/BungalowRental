using MediatR;
using RentaCar.Application.Features.Mediator.Queries.BlogQueries;
using RentaCar.Application.Features.Mediator.Results.BlogResults;
using RentaCar.Application.Interfaces;
using RentaCar.Application.Interfaces.BlogInterfaces;
using RentaCar.Domain.Entities;

namespace RentaCar.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetLast3BlogWithAuthorQueryHandler : IRequestHandler<GetLast3BlogWithAuthorQuery, List<GetLast3BlogWithAuthorQueryResult>>
    {
        private readonly IBlogRepository _repository;

        public GetLast3BlogWithAuthorQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetLast3BlogWithAuthorQueryResult>> Handle(GetLast3BlogWithAuthorQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetLast3BlogWithAuthor();
            return values.Select(x => new GetLast3BlogWithAuthorQueryResult{
                Id = x.Id,
                AuthorId = x.AuthorId,
                AuthorName = x.Author.Name,
                CategoryId = x.CategoryId,
                CoverImageUrl = x.CoverImageUrl,
                CreatedDate = x.CreatedDate,
                Title = x.Title,
            }).ToList();
        }
    }
}