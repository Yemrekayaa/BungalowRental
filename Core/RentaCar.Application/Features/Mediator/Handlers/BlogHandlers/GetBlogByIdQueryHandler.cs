using MediatR;
using RentaCar.Application.Features.Mediator.Queries.BlogQueries;
using RentaCar.Application.Features.Mediator.Results.BlogResults;
using RentaCar.Application.Interfaces;
using RentaCar.Domain.Entities;

namespace RentaCar.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogByIdQueryHandler : IRequestHandler<GetBlogByIdQuery, GetBlogByIdQueryResult>
    {
        private readonly IRepository<Blog> _repository;

        public GetBlogByIdQueryHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task<GetBlogByIdQueryResult> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetBlogByIdQueryResult{
                Id = value.Id,
                Title = value.Title,
                AuthorId = value.AuthorId,
                CategoryId = value.CategoryId,
                CoverImageUrl = value.CoverImageUrl
            };
        }
    }
}