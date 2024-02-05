using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.Address;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Write
{
    public interface IAddressWriteService :  IWriteService<AddressForUpdateDto,AddressForDeleteDto,AddressForAddDto,Address>
    {

    }

}
