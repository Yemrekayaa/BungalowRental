namespace RentaCar.Application.Features.CQRS.Results.BannerResults
{
    public class GetBannerByIdQueryResult
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string VideoDescription { get; set; }
        public string VideoUrl { get; set; }
    }
}