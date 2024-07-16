using MediatR;
using RentaCar.Application.Features.Mediator.Queries.BlogQueries;
using RentaCar.Application.Features.Mediator.Results.BlogResults;
using RentaCar.Application.Interfaces;
using RentaCar.Domain.Entities;

namespace RentaCar.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogQueryHandler : IRequestHandler<GetBlogQuery, List<GetBlogQueryResult>>
    {
        private readonly IRepository<Blog> _repository;

        public GetBlogQueryHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBlogQueryResult>> Handle(GetBlogQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetBlogQueryResult{
                Id = x.Id,
                Title = x.Title,
                CoverImageUrl = x.CoverImageUrl,
                AuthorId = x.AuthorId,
                CategoryId = x.CategoryId
            }).ToList();
        }
    }
}