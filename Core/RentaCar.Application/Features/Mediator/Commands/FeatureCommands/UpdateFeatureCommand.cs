
using MediatR;

namespace RentaCar.Application.Features.Mediator.Commands.FeatureCommands
{
    public class UpdateFeatureCommand : IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}