using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.Address;
using CoreLayer.DataTransferObjects.BrandDetail;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Write
{
    public interface IBrandDetailWriteService : IWriteService<BrandDetailForUpdateDto, BrandDetailForDeleteDto, BrandDetailForAddDto,BrandDetail>
    {

    }

}
