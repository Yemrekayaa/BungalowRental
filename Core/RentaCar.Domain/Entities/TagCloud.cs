namespace RentaCar.Domain.Entities
{
    public class TagCloud
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}