using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using CoreLayer.Enums;
using CoreLayer.Model;
using DataAccessLayer.Entities;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Services.Concretes
{
    public class ShipmentCompanyService : IShipmentCompanyService
    {
        public ShipmentCompanyDto Add(ShipmentCompanyDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<ShipmentCompanyDto> AddAsync(ShipmentCompanyDto dto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShipmentCompanyDto> AddRange(IEnumerable<ShipmentCompanyDto> dtos)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ShipmentCompanyDto>> AddRangeAsync(IEnumerable<ShipmentCompanyDto> dtos)
        {
            throw new NotImplementedException();
        }

        public ShipmentCompanyDto Delete(long id)
        {
            throw new NotImplementedException();
        }

        public ShipmentCompanyDto Delete(ShipmentCompanyDto dtos)
        {
            throw new NotImplementedException();
        }

        public Task<ShipmentCompanyDto> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShipmentCompanyDto> DeleteRange(IEnumerable<ShipmentCompanyDto> dtos)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShipmentCompanyDto> DeleteRange(Expression<Func<ShipmentCompany, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShipmentCompanyDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShipmentCompanyDto> GetAll(PaginationModel paginationModel, Expression<Func<ShipmentCompany, bool>> predicate, Expression<Func<ShipmentCompany, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<ShipmentCompany, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ShipmentCompanyDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<ShipmentCompany, bool>> predicate, Expression<Func<ShipmentCompany, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<ShipmentCompany, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public ShipmentCompanyDto GetById(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<ShipmentCompanyDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public ShipmentCompanyDto GetFirstOrDefault(Expression<Func<ShipmentCompany, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public Task<ShipmentCompanyDto> GetFirstOrDefaultAsync(Expression<Func<ShipmentCompany, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public (ShipmentCompanyDto, ShipmentCompanyDto) Update(ShipmentCompanyDto dtos)
        {
            throw new NotImplementedException();
        }
    }

}
