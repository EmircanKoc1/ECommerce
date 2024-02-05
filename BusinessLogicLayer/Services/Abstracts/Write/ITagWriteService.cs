using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.Tag;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Write
{
    public interface ITagWriteService : IWriteService<TagForUpdateDto, TagForDeleteDto, TagForAddDto, Tag>
    {
    }

}
