namespace CoreLayer.DataTransferObjects.Base
{
    public record BaseDtoForDelete : BaseDto
    {
        public long Id { get; init; }
    }
}
