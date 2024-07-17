using MediatR;
using RentaCar.Application.Features.Mediator.Queries.BlogQueries;
using RentaCar.Application.Features.Mediator.Results.BlogResults;
using RentaCar.Application.Interfaces.BlogInterfaces;

namespace RentaCar.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogWithAuthorQueryHandler : IRequestHandler<GetBlogWithAuthorQuery, List<GetBlogWithAuthorQueryResult>>
    {
        private readonly IBlogRepository _repository;

        public GetBlogWithAuthorQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBlogWithAuthorQueryResult>> Handle(GetBlogWithAuthorQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetBlogWithAuthor();
            return values.Select(x => new GetBlogWithAuthorQueryResult
            {
                Id = x.Id,
                AuthorId = x.AuthorId,
                AuthorName = x.Author.Name,
                CategoryId = x.CategoryId,
                CategoryName = x.Category.Name,
                CoverImageUrl = x.CoverImageUrl,
                CreatedDate = x.CreatedDate,
                Title = x.Title,
                Description = x.Description
            }).ToList();
        }
    }
}