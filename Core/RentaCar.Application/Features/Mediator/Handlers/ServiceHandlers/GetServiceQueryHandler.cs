using MediatR;
using RentaCar.Application.Features.Mediator.Queries.ServiceQueries;
using RentaCar.Application.Features.Mediator.Results.ServiceResults;
using RentaCar.Application.Interfaces;
using RentaCar.Domain.Entities;

namespace RentaCar.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class GetServiceQueryHandler : IRequestHandler<GetServiceQuery, List<GetServiceQueryResult>>
    {
        private readonly IRepository<Service> _repository;

        public GetServiceQueryHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetServiceQueryResult>> Handle(GetServiceQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetServiceQueryResult{
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                IconUrl = x.IconUrl
            }).ToList();
        }
    }
}