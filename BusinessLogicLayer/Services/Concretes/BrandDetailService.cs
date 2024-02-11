using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using CoreLayer.Enums;
using CoreLayer.Exceptions;
using CoreLayer.Model;
using DataAccessLayer.Entities;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Services.Concretes
{
    public class BrandDetailService : IBrandDetailService
    {
        public BrandDetailDto Add(BrandDetailDto dto)
        {
            BrandDetail brandDetail = null;
            
            if (dto.Brand is null && dto.BrandId is 0)
                throw new ForeignKeyOrNavigationPropertyNullException(nameof(Brand));

                                                                                                                                                                                                                                                                                                                                



        }

        public Task<BrandDetailDto> AddAsync(BrandDetailDto dto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BrandDetailDto> AddRange(IEnumerable<BrandDetailDto> dtos)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BrandDetailDto>> AddRangeAsync(IEnumerable<BrandDetailDto> dtos)
        {
            throw new NotImplementedException();
        }

        public BrandDetailDto Delete(long id)
        {
            throw new NotImplementedException();
        }

        public BrandDetailDto Delete(BrandDetailDto dtos)
        {
            throw new NotImplementedException();
        }

        public Task<BrandDetailDto> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BrandDetailDto> DeleteRange(IEnumerable<BrandDetailDto> dtos)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BrandDetailDto> DeleteRange(Expression<Func<BrandDetail, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BrandDetailDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BrandDetailDto> GetAll(PaginationModel paginationModel, Expression<Func<BrandDetail, bool>> predicate, Expression<Func<BrandDetail, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<BrandDetail, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BrandDetailDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<BrandDetail, bool>> predicate, Expression<Func<BrandDetail, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<BrandDetail, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public BrandDetailDto GetById(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<BrandDetailDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public BrandDetailDto GetFirstOrDefault(Expression<Func<BrandDetail, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public Task<BrandDetailDto> GetFirstOrDefaultAsync(Expression<Func<BrandDetail, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public (BrandDetailDto, BrandDetailDto) Update(BrandDetailDto dtos)
        {
            throw new NotImplementedException();
        }
    }

}
