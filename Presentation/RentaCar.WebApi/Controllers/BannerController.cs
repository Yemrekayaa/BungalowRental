using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using RentaCar.Application.Features.CQRS.Commands.BannerCommands;
using RentaCar.Application.Features.CQRS.Handlers.BannerHandlers;
using RentaCar.Application.Features.CQRS.Queries.BannerQueries;

namespace RentaCar.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BannerController : ControllerBase
    {
        private readonly CreateBannerCommandHandler _createBannerCommandHandler;
        private readonly RemoveBannerCommandHandler _removeBannerCommandHandler;
        private readonly UpdateBannerCommandHandler _updateBannerCommandHandler;
        private readonly GetBannerQueryHandler _getBannerQueryHandler;
        private readonly GetBannerByIdQueryHandler _getBannerByIdQueryHandler;

        public BannerController(CreateBannerCommandHandler createBannerCommandHandler, RemoveBannerCommandHandler removeBannerCommandHandler, UpdateBannerCommandHandler updateBannerCommandHandler, GetBannerQueryHandler getBannerQueryHandler, GetBannerByIdQueryHandler getBannerByIdQueryHandler)
        {
            _createBannerCommandHandler = createBannerCommandHandler;
            _removeBannerCommandHandler = removeBannerCommandHandler;
            _updateBannerCommandHandler = updateBannerCommandHandler;
            _getBannerQueryHandler = getBannerQueryHandler;
            _getBannerByIdQueryHandler = getBannerByIdQueryHandler;
        }

        [HttpGet]
        public async Task<IActionResult> ListBanner(){
            var values = await _getBannerQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBanner(int id){
            var value = await _getBannerByIdQueryHandler.Handle(new GetBannerByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBanner(CreateBannerCommand command){
            await _createBannerCommandHandler.Handle(command);
            return Ok("Created");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveBanner(RemoveBannerCommand command){
            await _removeBannerCommandHandler.Handle(command);
            return Ok("Removed");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBanner(UpdateBannerCommand command){
            await _updateBannerCommandHandler.Handle(command);
            return Ok("Updated");
        }
    }
}