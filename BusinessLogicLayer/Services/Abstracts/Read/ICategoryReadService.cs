using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.Category;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Read
{
    public interface ICategoryReadService : IReadService<CategoryForReadDto,Category>
    {
    }
}
