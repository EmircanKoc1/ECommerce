using AutoMapper;
using BusinessLogicLayer.Extensions;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using CoreLayer.Enums;
using CoreLayer.Model;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Abstracts;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Services.Concretes
{
    public class SubCategoryService : ISubCategoryService
    {
        IMapper _mapper;
        ISubCategoryRepository _repository;

        public SubCategoryService(IMapper mapper, ISubCategoryRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        void CustomValidator(SubCategoryDto dto)
        {
            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            if (dto.Category is null && dto.CategoryId is null or 0)
                dto.ThrowIfNull("", CustomException.ForeignKeyOrNavigationPropertyNullException);
        }

        public SubCategoryDto Add(SubCategoryDto dto)
        {
            CustomValidator(dto);

            var entity = _mapper.Map<SubCategory>(dto);
            _repository.Add(entity);
            _repository.SaveChanges();

            return _mapper.Map<SubCategoryDto>(dto);
        }

        public async Task<SubCategoryDto> AddAsync(SubCategoryDto dto)
        {
            CustomValidator(dto);

            var entity = _mapper.Map<SubCategory>(dto);
            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();

            return _mapper.Map<SubCategoryDto>(dto);

        }

        public IEnumerable<SubCategoryDto> AddRange(IEnumerable<SubCategoryDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                CustomValidator(dto);

            var entities = _mapper.Map<IEnumerable<SubCategory>>(dtos);
            _repository.AddRange(entities);
            _repository.SaveChanges();

            return _mapper.Map<IEnumerable<SubCategoryDto>>(entities);

        }

        public async Task<IEnumerable<SubCategoryDto>> AddRangeAsync(IEnumerable<SubCategoryDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                CustomValidator(dto);

            var entities = _mapper.Map<IEnumerable<SubCategory>>(dtos);
            await _repository.AddRangeAsync(entities);
            await _repository.SaveChangesAsync();

            return _mapper.Map<IEnumerable<SubCategoryDto>>(entities);
        }

        public SubCategoryDto Delete(long id)
        {
            var entity = _repository.GetById(false, id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<SubCategoryDto>(entity);
        }

        public SubCategoryDto Delete(SubCategoryDto dto)
        {
            var entity = _repository.GetById(false, dto.Id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);
            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<SubCategoryDto>(entity);

        }

        public async Task<SubCategoryDto> DeleteAsync(long id)
        {
            var entity = await _repository.GetByIdAsync(false, id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<SubCategoryDto>(entity);

        }

        public void DeleteRange(IEnumerable<SubCategoryDto> dtos)
        {

            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                CustomValidator(dto);

            var entities = _mapper.Map<IEnumerable<SubCategory>>(dtos);
            _repository.DeleteRange(entities);
            _repository.SaveChanges();

        }

        public void DeleteRange(Expression<Func<SubCategory, bool>> predicate)
        {
            predicate.ThrowIfNull("", CustomException.ParameterValueNullException);

            _repository.DeleteRange(predicate);
            _repository.SaveChanges();
        }

        public IEnumerable<SubCategoryDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            var entities = _repository.GetAll(paginationModel, tracking);
            entities.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<IEnumerable<SubCategoryDto>>(entities);
        }

        public IEnumerable<SubCategoryDto> GetAll(PaginationModel paginationModel, Expression<Func<SubCategory, bool>> predicate, Expression<Func<SubCategory, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<SubCategory, long>>[] thenByKeySelector)
        {
            var entities = _repository.GetAll(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);
            entities.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<IEnumerable<SubCategoryDto>>(entities);
        }

        public async Task<IEnumerable<SubCategoryDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<SubCategory, bool>> predicate, Expression<Func<SubCategory, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<SubCategory, long>>[] thenByKeySelector)
        {
            var entities = await _repository.GetAllAsync(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);
            entities.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<IEnumerable<SubCategoryDto>>(entities);
        }

        public SubCategoryDto GetById(bool tracking = false, params object[] keyValues)
        {
            var entity = _repository.GetById(false, keyValues);
            entity.ThrowIfNull("", CustomException.ParameterValueNullException);

            return _mapper.Map<SubCategoryDto>(entity);
        }

        public async Task<SubCategoryDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            var entity = await _repository.GetByIdAsync(false, keyValues);
            entity.ThrowIfNull("", CustomException.ParameterValueNullException);

            return _mapper.Map<SubCategoryDto>(entity);
        }

        public SubCategoryDto GetFirstOrDefault(Expression<Func<SubCategory, bool>> predicate, bool tracking = false)
        {
            var entity = _repository.GetFirstOrDefault(predicate, tracking);
            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<SubCategoryDto>(entity);
        }

        public async Task<SubCategoryDto> GetFirstOrDefaultAsync(Expression<Func<SubCategory, bool>> predicate, bool tracking = false)
        {
            var entity = await _repository.GetFirstOrDefaultAsync(predicate, tracking);
            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<SubCategoryDto>(entity);
        }

        public (SubCategoryDto, SubCategoryDto) Update(SubCategoryDto dto)
        {
            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var foundedEntity = _repository.GetById(false, dto.Id);
            foundedEntity.ThrowIfNull("", CustomException.EntityNotFoundException);

            var oldEntity = _mapper.Map<SubCategoryDto>(foundedEntity);
            var newEntity = _mapper.Map<SubCategory>(dto);

            _repository.Update(newEntity);
            _repository.SaveChanges();

            return (oldEntity, dto);
        }
    }

}
