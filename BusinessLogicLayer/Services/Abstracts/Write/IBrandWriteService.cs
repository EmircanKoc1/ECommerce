using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.Brand;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Write
{
    public interface IBrandWriteService : IWriteService<BrandForUpdateDto, BrandForDeleteDto, BrandForAddDto, Brand>
    {
    }

}
