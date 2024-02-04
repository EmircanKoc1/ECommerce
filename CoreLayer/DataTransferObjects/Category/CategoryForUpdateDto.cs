using CoreLayer.DataTransferObjects.Base;

namespace CoreLayer.DataTransferObjects.Category
{
    public record CategoryForUpdateDto : BaseDtoForUpdate
    {
        public string Name { get; init; }
        public string Description { get; init; }

    }


}
