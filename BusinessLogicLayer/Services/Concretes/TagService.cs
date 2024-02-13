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
    public class TagService : ITagService
    {
        IMapper _mapper;
        ITagRepository _repository;

        public TagService(IMapper mapper, ITagRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public TagDto Add(TagDto dto)
        {
            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var entity = _mapper.Map<Tag>(dto);
            _repository.Add(entity);
            _repository.SaveChanges();

            return _mapper.Map<TagDto>(entity);
        }

        public async Task<TagDto> AddAsync(TagDto dto)
        {
            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var entity = _mapper.Map<Tag>(dto);
            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();

            return _mapper.Map<TagDto>(entity);
        }

        public IEnumerable<TagDto> AddRange(IEnumerable<TagDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var entities = _mapper.Map<IEnumerable<Tag>>(dtos);
            _repository.AddRange(entities);
            _repository.SaveChanges();

            return _mapper.Map<IEnumerable<TagDto>>(entities);
        }

        public async Task<IEnumerable<TagDto>> AddRangeAsync(IEnumerable<TagDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var entities = _mapper.Map<IEnumerable<Tag>>(dtos);
            await _repository.AddRangeAsync(entities);
            await _repository.SaveChangesAsync();

            return _mapper.Map<IEnumerable<TagDto>>(entities);
        }

        public TagDto Delete(long id)
        {
            var entity = _repository.GetById(false, id);

            entity.ThrowIfNull("", CustomException.ParameterValueNullException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<TagDto>(entity);
        }

        public TagDto Delete(TagDto dto)
        {
            var entity = _repository.GetById(false, dto.Id);

            entity.ThrowIfNull("", CustomException.ParameterValueNullException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<TagDto>(entity);
        }

        public async Task<TagDto> DeleteAsync(long id)
        {
            var entity = await _repository.GetByIdAsync(false, id);

            entity.ThrowIfNull("", CustomException.ParameterValueNullException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<TagDto>(entity);
        }

        public void DeleteRange(IEnumerable<TagDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var entities = _mapper.Map<IEnumerable<Tag>>(dtos);

            _repository.DeleteRange(entities);
            _repository.SaveChanges();

        }

        public void DeleteRange(Expression<Func<Tag, bool>> predicate)
        {
            predicate.ThrowIfNull("", CustomException.ParameterValueNullException);

            _repository.DeleteRange(predicate);
            _repository.SaveChanges();
        }

        public IEnumerable<TagDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            var entities = _repository.GetAll(paginationModel, tracking);

            entities.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<IEnumerable<TagDto>>(entities);

        }

        public IEnumerable<TagDto> GetAll(PaginationModel paginationModel, Expression<Func<Tag, bool>> predicate, Expression<Func<Tag, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Tag, long>>[] thenByKeySelector)
        {
            var entities = _repository.GetAll(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);

            entities.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<IEnumerable<TagDto>>(entities);
        }

        public async Task<IEnumerable<TagDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<Tag, bool>> predicate, Expression<Func<Tag, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Tag, long>>[] thenByKeySelector)
        {
            var entities = await _repository.GetAllAsync(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);

            entities.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<IEnumerable<TagDto>>(entities);
        }

        public TagDto GetById(bool tracking = false, params object[] keyValues)
        {
            var entity = _repository.GetById(tracking, keyValues);
            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<TagDto>(entity);
        }

        public async Task<TagDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            var entity = await _repository.GetByIdAsync(tracking, keyValues);
            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<TagDto>(entity);
        }

        public TagDto GetFirstOrDefault(Expression<Func<Tag, bool>> predicate, bool tracking = false)
        {
            var entity = _repository.GetFirstOrDefault(predicate, tracking);
            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<TagDto>(entity);
        }

        public async Task<TagDto> GetFirstOrDefaultAsync(Expression<Func<Tag, bool>> predicate, bool tracking = false)
        {
            var entity = await _repository.GetFirstOrDefaultAsync(predicate, tracking);
            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<TagDto>(entity);
        }

        public (TagDto, TagDto) Update(TagDto dto)
        {
            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var foundedEntity = _repository.GetById(false, dto.Id);

            foundedEntity.ThrowIfNull("", CustomException.EntityNotFoundException);

            var oldEntity = _mapper.Map<TagDto>(foundedEntity);
            var newEntity = _mapper.Map<Tag>(dto);

            _repository.Update(newEntity);
            _repository.SaveChanges();

            return (oldEntity, dto);
        }
    }

}
