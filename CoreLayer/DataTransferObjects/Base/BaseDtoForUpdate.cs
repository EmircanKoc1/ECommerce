namespace CoreLayer.DataTransferObjects.Base
{
    public record BaseDtoForUpdate : BaseDto
    {
        public long Id { get; set; }
    }
}
