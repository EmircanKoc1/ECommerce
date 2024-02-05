using BusinessLogicLayer.Services.Abstracts.Read;
using CoreLayer.DataTransferObjects.Address;
using CoreLayer.Enums;
using CoreLayer.Model;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Concretes.Read
{
    public class AddressReadService : IAddressReadService
    {
        public IEnumerable<AddressForReadDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AddressForReadDto> GetAll(bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public IQueryable<AddressForReadDto> GetAll(PaginationModel paginationModel, Expression<Func<Address, bool>> predicate, Expression<Func<Address, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Address, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AddressForReadDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<Address, bool>> predicate, Expression<Func<Address, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Address, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public AddressForReadDto GetById(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<AddressForReadDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<AddressForReadDto> GetByWithIncludesAsync(long id, bool tracking = false, params Expression<Func<Address, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public AddressForReadDto GetFirstOrDefault(Expression<Func<Address, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public Task<AddressForReadDto> GetFirstOrDefaultAsync(Expression<Func<Address, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }
    }

}
