using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DTOs;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts
{
    public interface ITagService : IBaseReadService<TagDto, Tag>, IBaseWriteService<TagDto, Tag>
    {
    }
}
