using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.Product;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Read
{
    public interface IProductReadService : IReadService<ProductForReadDto,Product>
    {
    }
}
