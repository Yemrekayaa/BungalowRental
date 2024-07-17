
namespace RentaCar.Domain.Entities
{
    public class Blog
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public String CoverImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Description { get; set; }
        public List<TagCloud> TagClouds { get; set; }
    }
}