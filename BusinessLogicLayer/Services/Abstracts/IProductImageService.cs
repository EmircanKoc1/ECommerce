using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DTOs;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts
{
    public interface IProductImageService : IBaseReadService<ProductImageDto, ProductImage>, IBaseWriteService<ProductImageDto, ProductImage>
    {
    }
}
