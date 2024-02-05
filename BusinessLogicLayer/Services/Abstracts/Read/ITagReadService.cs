using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.Tag;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Read
{
    public interface ITagReadService : IReadService<TagForReadDto,Tag>
    {
    }
}
