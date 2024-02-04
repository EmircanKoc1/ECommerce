using CoreLayer.DataTransferObjects.Base;

namespace CoreLayer.DataTransferObjects.Tag
{
    public record TagForUpdateDto : BaseDtoForUpdate
    {
        public string Name { get; init; }
        public string Description { get; init; }

    }


}
