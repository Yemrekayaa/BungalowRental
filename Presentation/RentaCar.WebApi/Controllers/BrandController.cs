using Microsoft.AspNetCore.Mvc;
using RentaCar.Application.Features.CQRS.Commands.BrandCommands;
using RentaCar.Application.Features.CQRS.Handlers.BrandHandlers;
using RentaCar.Application.Features.CQRS.Queries.BrandQueries;

namespace RentaCar.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BrandController : ControllerBase
    {
        private readonly GetBrandByIdQueryHandler _getBrandByIdQueryHandler;
        private readonly GetBrandQueryHandler _getBrandQueryHandler;
        private readonly CreateBrandCommandHandler _createBrandCommandHandler;
        private readonly RemoveBrandCommandHandler _removeBrandCommandHandler;
        private readonly UpdateBrandCommandHandler _updateBrandCommandHandler;

        public BrandController(GetBrandByIdQueryHandler getBrandByIdQueryHandler, GetBrandQueryHandler getBrandQueryHandler, CreateBrandCommandHandler createBrandCommandHandler, RemoveBrandCommandHandler removeBrandCommandHandler, UpdateBrandCommandHandler updateBrandCommandHandler)
        {
            _getBrandByIdQueryHandler = getBrandByIdQueryHandler;
            _getBrandQueryHandler = getBrandQueryHandler;
            _createBrandCommandHandler = createBrandCommandHandler;
            _removeBrandCommandHandler = removeBrandCommandHandler;
            _updateBrandCommandHandler = updateBrandCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> BrandList(){
            var values = await _getBrandQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> BrandGetById(int id){
            var value = await _getBrandByIdQueryHandler.Handle(new GetBrandByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBrand(CreateBrandCommand command){
            await _createBrandCommandHandler.Handle(command);
            return Ok("Created");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBrand(UpdateBrandCommand command){
            await _updateBrandCommandHandler.Handle(command);
            return Ok("Updated");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveBrand(RemoveBrandCommand command){
            await _removeBrandCommandHandler.Handle(command);
            return Ok("Removed");
        }
    }
}