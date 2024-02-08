using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DTOs;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts
{
    public interface IProductFeatureService : IBaseReadService<ProductFeatureDto, ProductFeature>, IBaseWriteService<ProductFeatureDto, ProductFeature>
    {
    }
}
