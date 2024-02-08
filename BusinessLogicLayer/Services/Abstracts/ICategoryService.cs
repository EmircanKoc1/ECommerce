using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DTOs;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts
{
    public interface ICategoryService : IBaseReadService<CategoryDto, Category>, IBaseWriteService<CategoryDto, Category>
    {
    }
}
