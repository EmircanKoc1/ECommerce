using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.Address;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Read
{
    public interface IAddressReadService : IReadService<AddressForReadDto, Address>
    {

    }
}
