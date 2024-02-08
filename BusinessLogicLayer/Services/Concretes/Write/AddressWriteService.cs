using BusinessLogicLayer.Services.Abstracts.Write;
using CoreLayer.DataTransferObjects.Address;
using DataAccessLayer.Repositories.Abstracts;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Services.Concretes.Write
{
    public class AddressWriteService : IAddressWriteService
    {
        IAddressRepository _addressRepository;

        public AddressWriteService(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public bool Add(AddressForAddDto dto)
        {
            return true;

        }

        public Task<bool> AddAsync(AddressForAddDto dto)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<AddressForAddDto> dtos)
        {
            throw new NotImplementedException();
        }

        public Task AddRangeAsync(IEnumerable<AddressForAddDto> dtos)
        {
            throw new NotImplementedException();
        }

        public bool Delete(long id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(AddressForDeleteDto dtos)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(IEnumerable<AddressForDeleteDto> dtos)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(Expression<Func<AddressForDeleteDto, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(AddressForUpdateDto dtos)
        {
            throw new NotImplementedException();
        }
    }
}
