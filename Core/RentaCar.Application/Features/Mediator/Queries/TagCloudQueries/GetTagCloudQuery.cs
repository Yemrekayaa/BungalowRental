using MediatR;
using RentaCar.Application.Features.Mediator.Results.TagCloudResults;

namespace RentaCar.Application.Features.Mediator.Queries.TagCloudQueries
{
    public class GetTagCloudQuery : IRequest<List<GetTagCloudQueryResult>>
    {

    }
}