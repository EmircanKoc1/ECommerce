using CoreLayer.DataTransferObjects.Base;

namespace CoreLayer.DataTransferObjects.Tag
{
    public record TagForReadDto : BaseDtoForRead
    {
        public string Name { get; init; }
        public string Description { get; init; }
    }


}
