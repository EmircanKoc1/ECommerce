using CoreLayer.DataTransferObjects.Base;

namespace CoreLayer.DataTransferObjects.Comment
{
    public record CommentForAddDto : BaseDtoForAdd
    {
        public string Title { get; init; }
        public string Text { get; init; }
        public byte Score { get; init; }
        public long? ProductId { get; init; }
        public long? UserId { get; init; }
    }

}
