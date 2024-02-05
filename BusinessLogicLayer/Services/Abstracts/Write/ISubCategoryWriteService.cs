using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.SubCategory;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Write
{
    public interface ISubCategoryWriteService : IWriteService<SubCategoryForUpdateDto, SubCategoryForDeleteDto, SubCategoryForAddDto, SubCategory>
    {
    }

}
