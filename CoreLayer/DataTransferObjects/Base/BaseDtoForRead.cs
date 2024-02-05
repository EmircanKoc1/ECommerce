namespace CoreLayer.DataTransferObjects.Base
{
    public record BaseDtoForRead : BaseDto
    {
        public long Id { get; init; }

    }
}
