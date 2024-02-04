using CoreLayer.DataTransferObjects.Base;

namespace CoreLayer.DataTransferObjects.Tag
{
    public record TagForAddDto : BaseDtoForAdd
    {
        public string Name { get; init; }
        public string Description { get; init; }

    }


}
