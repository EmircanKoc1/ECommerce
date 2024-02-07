namespace CoreLayer.DTOs
{
    public class BrandDetailDto : BaseDto
    {
        public string Description { get; set; }
        public string LogoPath { get; set; }
        public DateTime? FoundedYear { get; set; }
        public long? BrandId { get; set; }
        public BrandDto Brand { get; set; }
    }
}
