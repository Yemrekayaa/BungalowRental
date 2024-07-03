
using MediatR;
using RentaCar.Application.Features.Mediator.Queries.FooterAddressQueries;
using RentaCar.Application.Features.Mediator.Results.FooterAddressResults;
using RentaCar.Application.Interfaces;
using RentaCar.Domain.Entities;

namespace RentaCar.Application.Features.Mediator.Handlers.FooterAddressHandlers
{
    public class GetFooterAddressQueryHandler : IRequestHandler<GetFooterAddressQuery, List<GetFooterAdressQueryResult>>
    {
        private readonly IRepository<FooterAddress> _repository;

        public GetFooterAddressQueryHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetFooterAdressQueryResult>> Handle(GetFooterAddressQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetFooterAdressQueryResult{
                Id = x.Id,
                Address = x.Address,
                Description = x.Description,
                Email = x.Email,
                Phone = x.Phone,
            }).ToList();
        }
    }
}