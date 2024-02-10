using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using CoreLayer.Enums;
using CoreLayer.Model;
using DataAccessLayer.Entities;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Services.Concretes
{
    public class SubCategoryService : ISubCategoryService
    {
        public SubCategoryDto Add(SubCategoryDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<SubCategoryDto> AddAsync(SubCategoryDto dto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SubCategoryDto> AddRange(IEnumerable<SubCategoryDto> dtos)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SubCategoryDto>> AddRangeAsync(IEnumerable<SubCategoryDto> dtos)
        {
            throw new NotImplementedException();
        }

        public SubCategoryDto Delete(long id)
        {
            throw new NotImplementedException();
        }

        public SubCategoryDto Delete(SubCategoryDto dtos)
        {
            throw new NotImplementedException();
        }

        public Task<SubCategoryDto> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SubCategoryDto> DeleteRange(IEnumerable<SubCategoryDto> dtos)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SubCategoryDto> DeleteRange(Expression<Func<SubCategory, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SubCategoryDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SubCategoryDto> GetAll(PaginationModel paginationModel, Expression<Func<SubCategory, bool>> predicate, Expression<Func<SubCategory, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<SubCategory, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SubCategoryDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<SubCategory, bool>> predicate, Expression<Func<SubCategory, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<SubCategory, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public SubCategoryDto GetById(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<SubCategoryDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public SubCategoryDto GetFirstOrDefault(Expression<Func<SubCategory, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public Task<SubCategoryDto> GetFirstOrDefaultAsync(Expression<Func<SubCategory, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public (SubCategoryDto, SubCategoryDto) Update(SubCategoryDto dtos)
        {
            throw new NotImplementedException();
        }
    }

}
