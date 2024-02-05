using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.ProductFeature;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Write
{
    public interface IProductFeatureWriteService : IWriteService<ProductFeatureForUpdateDto, ProductFeatureForDeleteDto, ProductFeatureForAddDto, ProductFeature>
    {
    }

}
