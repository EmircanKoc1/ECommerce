using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using CoreLayer.Enums;
using CoreLayer.Model;
using DataAccessLayer.Entities;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Services.Concretes
{
    public class BrandService : IBrandService
    {
        public BrandDto Add(BrandDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<BrandDto> AddAsync(BrandDto dto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BrandDto> AddRange(IEnumerable<BrandDto> dtos)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BrandDto>> AddRangeAsync(IEnumerable<BrandDto> dtos)
        {
            throw new NotImplementedException();
        }

        public BrandDto Delete(long id)
        {
            throw new NotImplementedException();
        }

        public BrandDto Delete(BrandDto dtos)
        {
            throw new NotImplementedException();
        }

        public Task<BrandDto> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BrandDto> DeleteRange(IEnumerable<BrandDto> dtos)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BrandDto> DeleteRange(Expression<Func<Brand, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BrandDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BrandDto> GetAll(PaginationModel paginationModel, Expression<Func<Brand, bool>> predicate, Expression<Func<Brand, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Brand, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BrandDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<Brand, bool>> predicate, Expression<Func<Brand, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Brand, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public BrandDto GetById(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<BrandDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public BrandDto GetFirstOrDefault(Expression<Func<Brand, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public Task<BrandDto> GetFirstOrDefaultAsync(Expression<Func<Brand, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public (BrandDto, BrandDto) Update(BrandDto dtos)
        {
            throw new NotImplementedException();
        }
    }

}
