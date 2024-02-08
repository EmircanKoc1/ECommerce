using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DTOs;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts
{
    public interface IProductService : IBaseReadService<ProductDto, Product>, IBaseWriteService<ProductDto, Product>
    {
    }
}
