
namespace RentaCar.Dto.BlogDtos
{
    public class ResultLast3BlogWithAuthorDto
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public int AuthorId { get; set; }
        public String AuthorName { get; set; }
        public String CoverImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CategoryId { get; set; }
    }
}