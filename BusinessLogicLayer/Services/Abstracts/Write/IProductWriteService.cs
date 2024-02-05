using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.Product;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Write
{
    public interface IProductWriteService : IWriteService<ProductForUpdateDto, ProductForDeleteDto, ProductForAddDto, Product>
    {
    }

}
