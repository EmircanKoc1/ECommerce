namespace CoreLayer.DTOs
{
    public class CommentDto : BaseDto
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public byte Score { get; set; }

        public long? ProductId { get; set; }
        public ProductDto Product { get; set; }

        public long? UserId { get; set; }
        public UserDto User { get; set; }
    }
}
