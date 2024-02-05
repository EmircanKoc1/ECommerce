using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.BrandDetail;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Read
{
    public interface IBrandDetailReadService : IReadService<BrandDetailForReadDto, BrandDetail>
    {
    }
}
