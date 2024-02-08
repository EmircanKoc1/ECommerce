using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DTOs;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts
{
    public interface ISubCategoryService : IBaseReadService<SubCategoryDto, SubCategory>, IBaseWriteService<SubCategoryDto, SubCategory>
    {
    }
}
