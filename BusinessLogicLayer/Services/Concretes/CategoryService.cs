using AutoMapper;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using CoreLayer.Enums;
using CoreLayer.Exceptions;
using CoreLayer.Model;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Abstracts;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Services.Concretes
{
    public class CategoryService : ICategoryService
    {
        ICategoryRepository _repository;
        IMapper _mapper;

        public CategoryService(IMapper mapper, ICategoryRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public CategoryDto Add(CategoryDto dto)
        {
            Category entity = null;

            if (dto is null)
                throw new ParameterValueNullException(nameof(Category));

            if (dto.Id is not 0)
                entity = _repository.GetById(false, dto.Id);

            if (entity is not null)
                throw new EntityAlreadyExistsException(nameof(entity));

            entity = _mapper.Map<Category>(dto);

            _repository.Add(entity);
            _repository.SaveChanges();

            return _mapper.Map<CategoryDto>(entity);

        }

        public async Task<CategoryDto> AddAsync(CategoryDto dto)
        {
            Category entity = null;

            if (dto is null)
                throw new ParameterValueNullException(nameof(Category));

            if (dto.Id is not 0)
                entity = await _repository.GetByIdAsync(false, dto.Id);

            if (entity is not null)
                throw new EntityAlreadyExistsException(nameof(Category));


            entity = _mapper.Map<Category>(dto);

            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();

            return _mapper.Map<CategoryDto>(entity);

        }

        public IEnumerable<CategoryDto> AddRange(IEnumerable<CategoryDto> dtos)
        {
            if (dtos is null)
                throw new ParameterValueNullException(nameof(Category));

            var entities = _mapper.Map<IEnumerable<Category>>(dtos);

            _repository.AddRange(entities);
            _repository.SaveChanges();

            return _mapper.Map<IEnumerable<CategoryDto>>(entities);

        }

        public async Task<IEnumerable<CategoryDto>> AddRangeAsync(IEnumerable<CategoryDto> dtos)
        {
            if (dtos is null)
                throw new ParameterValueNullException(nameof(Category));

            var entities = _mapper.Map<IEnumerable<Category>>(dtos);

            await _repository.AddRangeAsync(entities);
            await _repository.SaveChangesAsync();

            return _mapper.Map<IEnumerable<CategoryDto>>(entities);
        }

        public CategoryDto Delete(long id)
        {
            var entity = _repository.GetById(false, id);

            if (entity is null)
                throw new EntityNotFoundException(nameof(Category));

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<CategoryDto>(entity);

        }

        public CategoryDto Delete(CategoryDto dto)
        {
            var entity = _repository.GetById(false, dto.Id);

            if (entity is null)
                throw new EntityNotFoundException(nameof(Category));

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<CategoryDto>(entity);
        }

        public async Task<CategoryDto> DeleteAsync(long id)
        {
            var entity = await _repository.GetByIdAsync(false, id);

            if (entity is null)
                throw new EntityNotFoundException(nameof(Category));

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<CategoryDto>(entity);

        }

        public void  DeleteRange(IEnumerable<CategoryDto> dtos)
        {
            if (dtos is null)
                throw new ParameterValueNullException(nameof(Category));

            var entities = _mapper.Map<IEnumerable<Category>>(dtos);

            _repository.DeleteRange(entities);
            _repository.SaveChanges();

          
        }

        public void DeleteRange(Expression<Func<Category, bool>> predicate)
        {
            var entities = _repository.GetAll().Where(predicate);

            if (entities is null)
                throw new EntityNotFoundException("");

            foreach (var entity in entities)
                _repository.Delete(entity);
            _repository.SaveChanges();

          

        }

        public IEnumerable<CategoryDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {

            var entities = _repository.GetAll(paginationModel, tracking);
            return _mapper.Map<IEnumerable<CategoryDto>>(entities);

        }

        public IEnumerable<CategoryDto> GetAll(PaginationModel paginationModel, Expression<Func<Category, bool>> predicate, Expression<Func<Category, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Category, long>>[] thenByKeySelector)
        {
            var entities = _repository.GetAll(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);

            return _mapper.Map<IEnumerable<CategoryDto>>(entities);
        }

        public async Task<IEnumerable<CategoryDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<Category, bool>> predicate, Expression<Func<Category, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Category, long>>[] thenByKeySelector)
        {
            var entites = _repository.GetAllAsync(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);

            return _mapper.Map<IEnumerable<CategoryDto>>(entites);

        }

        public CategoryDto GetById(bool tracking = false, params object[] keyValues)
        {
            var entity = _repository.GetById(tracking, keyValues);

            return _mapper.Map<CategoryDto>(entity);

        }

        public async Task<CategoryDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            var entity = await _repository.GetByIdAsync(tracking, keyValues);

            return _mapper.Map<CategoryDto>(entity);
        }

        public CategoryDto GetFirstOrDefault(Expression<Func<Category, bool>> predicate, bool tracking = false)
        {
            var entity = _repository.GetFirstOrDefault(predicate, tracking);

            return _mapper.Map<CategoryDto>(entity);
        }

        public async Task<CategoryDto> GetFirstOrDefaultAsync(Expression<Func<Category, bool>> predicate, bool tracking = false)
        {
            var entity = await _repository.GetFirstOrDefaultAsync(predicate, tracking);

            return _mapper.Map<CategoryDto>(entity);
        }

        public (CategoryDto, CategoryDto) Update(CategoryDto dtos)
        {

            if (dtos is null)
                throw new ParameterValueNullException(nameof(Category));

            var foundedEntity = _repository.GetById(false, dtos.Id);

            if (foundedEntity is null)
                throw new EntityNotFoundException(nameof(Category));

            var oldEntity = _mapper.Map<CategoryDto>(foundedEntity);
            var newEntity = _mapper.Map<Category>(dtos);
            _repository.Update(newEntity);
            _repository.SaveChanges();


            return (oldEntity, dtos);

        }
    }

}
