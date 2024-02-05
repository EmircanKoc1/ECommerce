using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.SubCategory;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Read
{
    public interface ISubCategoryReadService : IReadService<SubCategoryForReadDto,SubCategory>
    {
    }
}
