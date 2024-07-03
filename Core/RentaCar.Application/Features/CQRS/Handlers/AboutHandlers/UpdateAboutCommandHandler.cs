using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RentaCar.Application.Features.CQRS.Commands.AboutCommands;
using RentaCar.Application.Interfaces;
using RentaCar.Domain.Entities;

namespace RentaCar.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class UpdateAboutCommandHandler
    {
        private readonly IRepository<About> _repository;

        public UpdateAboutCommandHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAboutCommand command){
            var value = await _repository.GetByIdAsync(command.Id);
            value.Description = command.Description;
            value.ImageUrl = command.ImageUrl;
            value.Title = command.Title;
            await _repository.UpdateAsync(value);
        }
    }
}