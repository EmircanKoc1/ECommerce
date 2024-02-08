using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DTOs;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts
{
    public interface IAddressService : IBaseReadService<AddressDto, Address>, IBaseWriteService<AddressDto, Address>
    {





    }
}
