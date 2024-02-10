using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using CoreLayer.Enums;
using CoreLayer.Model;
using DataAccessLayer.Entities;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Services.Concretes
{
    public class ShipmentCompanyDetailService : IShipmentCompanyDetailService
    {
        public ShipmentCompanyDetailDto Add(ShipmentCompanyDetailDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<ShipmentCompanyDetailDto> AddAsync(ShipmentCompanyDetailDto dto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShipmentCompanyDetailDto> AddRange(IEnumerable<ShipmentCompanyDetailDto> dtos)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ShipmentCompanyDetailDto>> AddRangeAsync(IEnumerable<ShipmentCompanyDetailDto> dtos)
        {
            throw new NotImplementedException();
        }

        public ShipmentCompanyDetailDto Delete(long id)
        {
            throw new NotImplementedException();
        }

        public ShipmentCompanyDetailDto Delete(ShipmentCompanyDetailDto dtos)
        {
            throw new NotImplementedException();
        }

        public Task<ShipmentCompanyDetailDto> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShipmentCompanyDetailDto> DeleteRange(IEnumerable<ShipmentCompanyDetailDto> dtos)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShipmentCompanyDetailDto> DeleteRange(Expression<Func<ShipmentCompanyDetail, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShipmentCompanyDetailDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShipmentCompanyDetailDto> GetAll(PaginationModel paginationModel, Expression<Func<ShipmentCompanyDetail, bool>> predicate, Expression<Func<ShipmentCompanyDetail, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<ShipmentCompanyDetail, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ShipmentCompanyDetailDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<ShipmentCompanyDetail, bool>> predicate, Expression<Func<ShipmentCompanyDetail, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<ShipmentCompanyDetail, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public ShipmentCompanyDetailDto GetById(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<ShipmentCompanyDetailDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public ShipmentCompanyDetailDto GetFirstOrDefault(Expression<Func<ShipmentCompanyDetail, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public Task<ShipmentCompanyDetailDto> GetFirstOrDefaultAsync(Expression<Func<ShipmentCompanyDetail, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public (ShipmentCompanyDetailDto, ShipmentCompanyDetailDto) Update(ShipmentCompanyDetailDto dtos)
        {
            throw new NotImplementedException();
        }
    }

}
