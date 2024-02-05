using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.ProductImage;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Write
{
    public interface IProductImageWriteService : IWriteService<ProductImageForUpdateDto, ProductImageForDeleteDto, ProductImageForAddDto, ProductImage>
    {
    }

}
