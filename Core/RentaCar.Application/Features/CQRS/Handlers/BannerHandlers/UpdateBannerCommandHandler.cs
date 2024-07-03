using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RentaCar.Application.Features.CQRS.Commands.BannerCommands;
using RentaCar.Application.Interfaces;
using RentaCar.Domain.Entities;

namespace RentaCar.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class UpdateBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;

        public UpdateBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBannerCommand command){
            var value = await _repository.GetByIdAsync(command.Id);
            value.Title = command.Title;
            value.Description = command.Description;
            value.VideoDescription = command.VideoDescription;
            value.VideoUrl = command.VideoUrl;
            await _repository.UpdateAsync(value);
        }
    }
}