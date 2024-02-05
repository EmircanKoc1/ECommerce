using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.Brand;
using CoreLayer.DataTransferObjects.BrandDetail;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Read
{
    public interface IBrandReadService : IReadService<BrandForReadDto,Brand>
    {
    }
}
