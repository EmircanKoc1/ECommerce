using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.Category;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Write
{
    public interface ICategoryWriteService : IWriteService<CategoryForUpdateDto, CategoryForDeleteDto, CategoryForAddDto, Category>
    {

    }

}
