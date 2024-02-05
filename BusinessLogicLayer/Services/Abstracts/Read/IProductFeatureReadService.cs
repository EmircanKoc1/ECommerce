using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.ProductFeature;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Read
{
    public interface IProductFeatureReadService : IReadService<ProductFeatureForReadDto,ProductFeature>
    {
    }
}
