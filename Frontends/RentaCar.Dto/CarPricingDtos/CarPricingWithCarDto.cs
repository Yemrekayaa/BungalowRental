namespace RentaCar.Dto.CarPricingDtos
{
    public class ResultCarPricingWithCarDto
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Amount { get; set; }
        public string CoverImageUrl { get; set; }
    }
}