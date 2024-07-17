namespace RentaCar.Application.Features.Mediator.Results.BlogResults
{
    public class GetBlogWithAuthorQueryResult
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string CategoryName { get; set; }
        public String CoverImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
    }
}