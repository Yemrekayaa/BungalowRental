
using MediatR;
using RentaCar.Application.Features.Mediator.Queries.ServiceQueries;
using RentaCar.Application.Features.Mediator.Results.ServiceResults;
using RentaCar.Application.Interfaces;
using RentaCar.Domain.Entities;

namespace RentaCar.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class GetServiceByIdQueryHandler : IRequestHandler<GetServiceByIdQuery, GetServiceByIdQueryResult>
    {
        private readonly IRepository<Service> _repository;

        public GetServiceByIdQueryHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<GetServiceByIdQueryResult> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetServiceByIdQueryResult{
                Id = value.Id,
                Description = value.Description,
                Title = value.Title,
                IconUrl = value.IconUrl
            };
        }
    }
}