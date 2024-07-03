
using RentaCar.Application.Features.CQRS.Queries.ContactQueries;
using RentaCar.Application.Features.CQRS.Results.ContactResults;
using RentaCar.Application.Interfaces;
using RentaCar.Domain.Entities;

namespace RentaCar.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class GetContactByIdQueryHandler
    {
        private readonly IRepository<Contact> _repository;

        public GetContactByIdQueryHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task<GetContactByIdQueryResult> Handle(GetContactByIdQuery query){
            var value = await _repository.GetByIdAsync(query.Id);
            return new GetContactByIdQueryResult{
                Id = value.Id,
                Name = value.Name,
                Email = value.Email,
                Subject = value.Subject,
                Message = value.Message,
                SendDate = value.SendDate
            };
        }
    }
}